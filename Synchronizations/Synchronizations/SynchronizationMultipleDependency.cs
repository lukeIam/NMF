﻿using NMF.Expressions;
using NMF.Transformations;
using NMF.Transformations.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NMF.Synchronizations
{
    internal class SynchronizationMultipleDependency<TLeft, TRight, TDepLeft, TDepRight>
        where TLeft : class
        where TRight : class
        where TDepLeft : class
        where TDepRight : class
    {
        private SynchronizationRule<TLeft, TRight> parentRule;
        private SynchronizationRule<TDepLeft, TDepRight> childRule;

        private Func<TLeft, ICollectionExpression<TDepLeft>> __leftGetter;
        private Func<TRight, ICollectionExpression<TDepRight>> __rightGetter;

        public SynchronizationMultipleDependency(SynchronizationRule<TLeft, TRight> parentRule, SynchronizationRule<TDepLeft, TDepRight> childRule, Expression<Func<TLeft, ICollectionExpression<TDepLeft>>> leftSelector, Expression<Func<TRight, ICollectionExpression<TDepRight>>> rightSelector)
        {
            if (parentRule == null) throw new ArgumentNullException("parentRule");
            if (childRule == null) throw new ArgumentNullException("childRule");
            if (leftSelector == null) throw new ArgumentNullException("leftSelector");
            if (rightSelector == null) throw new ArgumentNullException("rightSelector");

            this.parentRule = parentRule;
            this.childRule = childRule;

            this.__leftGetter = ExpressionCompileRewriter.Compile(leftSelector);
            this.__rightGetter = ExpressionCompileRewriter.Compile(rightSelector);
        }

        private ICollection<TDepLeft> GetLefts(TLeft left, bool incremental)
        {
            var lefts = __leftGetter(left);
            if (incremental)
            {
                return lefts.AsNotifiable();
            }
            else
            {
                return lefts;
            }
        }

        private ICollection<TDepRight> GetRights(TRight right, bool incremental)
        {
            var rights = __rightGetter(right);
            if (incremental)
            {
                return rights.AsNotifiable();
            }
            else
            {
                return rights;
            }
        }

        public void HandleLeftToRightDependency(Computation computation)
        {
            var syncComputation = computation as SynchronizationComputation<TLeft, TRight>;
            var input = GetLefts(syncComputation.Input, syncComputation.SynchronizationContext.ChangePropagation != ChangePropagationMode.None);
            syncComputation.DoWhenOutputIsAvailable((inp, outp) =>
            {
                SynchronizeLTRCollections(input, GetRights(outp, syncComputation.SynchronizationContext.ChangePropagation == ChangePropagationMode.TwoWay), syncComputation.SynchronizationContext, syncComputation.OmitCandidateSearch, syncComputation.Dependencies);
            });
        }

        public void HandleRightToLeftDependency(Computation computation)
        {
            var syncComputation = computation as SynchronizationComputation<TRight, TLeft>;
            var input = GetRights(syncComputation.Input, syncComputation.SynchronizationContext.ChangePropagation != ChangePropagationMode.None);
            syncComputation.DoWhenOutputIsAvailable((inp, outp) =>
            {
                SynchronizeRTLCollections(GetLefts(outp, syncComputation.SynchronizationContext.ChangePropagation == ChangePropagationMode.TwoWay), input, syncComputation.SynchronizationContext, syncComputation.OmitCandidateSearch, syncComputation.Dependencies);
            });
        }

        private void SynchronizeLTRCollections(ICollection<TDepLeft> lefts, ICollection<TDepRight> rights, ISynchronizationContext context, bool ignoreCandidates, Queue<IDisposable> dependencies)
        {
            if (rights != null)
            {
                if (rights.IsReadOnly) throw new InvalidOperationException("Collection is read-only!");
                IEnumerable<TDepRight> rightsSaved = rights;
                if (lefts == null || context.Direction == SynchronizationDirection.LeftToRightForced)
                {
                    rightsSaved = rights.ToArray();
                    rights.Clear();
                }
                var doubles = new HashSet<TDepRight>();
                IEnumerable rightContext = ignoreCandidates ? null : rights;
                foreach (var item in lefts)
                {
                    var comp = context.CallTransformation(childRule.LeftToRight, new object[] { item }, rightContext) as SynchronizationComputation<TDepLeft, TDepRight>;
                    comp.DoWhenOutputIsAvailable((inp, outp) =>
                    {
                        if (!rights.Contains(outp))
                        {
                            rights.Add(outp);
                        }
                        else
                        {
                            doubles.Add(outp);
                        }
                    });
                }
                if (context.Direction == SynchronizationDirection.LeftWins)
                {
                    foreach (var item in rightsSaved.Except(doubles))
                    {
                        AddCorrespondingToLefts(lefts, context, item);
                    }
                }
                RegisterLeftChangePropagationHooks(lefts, rights, context, dependencies);
            }
            else
            {
                throw new NotSupportedException("Target collection must not be null!");
            }
        }

        private void RegisterLeftChangePropagationHooks(ICollection<TDepLeft> lefts, ICollection<TDepRight> rights, ISynchronizationContext context, Queue<IDisposable> dependencies)
        {
            if (context.ChangePropagation == ChangePropagationMode.OneWay)
            {
                if (lefts is INotifyCollectionChanged)
                {
                    dependencies.Enqueue(new LeftToRightHook(lefts, rights, context, this));
                }
            }
            RegisterTwoWayChangePropagation(lefts, rights, context, dependencies);
        }

        private void RegisterRightChangePropagationHooks(ICollection<TDepLeft> lefts, ICollection<TDepRight> rights, ISynchronizationContext context, Queue<IDisposable> dependencies)
        {
            if (context.ChangePropagation == ChangePropagationMode.OneWay)
            {
                if (rights is INotifyCollectionChanged)
                {
                    dependencies.Enqueue(new RightToLeftHook(lefts, rights, context, this));
                }
            }
            RegisterTwoWayChangePropagation(lefts, rights, context, dependencies);
        }

        private void RegisterTwoWayChangePropagation(ICollection<TDepLeft> lefts, ICollection<TDepRight> rights, ISynchronizationContext context, Queue<IDisposable> dependencies)
        {
            if (context.ChangePropagation == ChangePropagationMode.TwoWay)
            {
                var leftNotifier = lefts is INotifyCollectionChanged;
                var rightNotifier = rights is INotifyCollectionChanged;
                if (leftNotifier)
                {
                    if (rightNotifier)
                    {
                        dependencies.Enqueue(new BidirectionalHook(lefts, rights, context, this));
                    }
                    else
                    {
                        dependencies.Enqueue(new LeftToRightHook(lefts, rights, context, this));
                    }
                }
                else if (rightNotifier)
                {
                    dependencies.Enqueue(new RightToLeftHook(lefts, rights, context, this));
                }
            }
        }

        private void ProcessRightChangesForLefts(ICollection<TDepLeft> lefts, ICollection<TDepRight> rights, ISynchronizationContext context, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action != NotifyCollectionChangedAction.Reset)
            {
                if (e.OldItems != null)
                {
                    for (int i = e.OldItems.Count - 1; i >= 0; i--)
                    {
                        TDepRight item = (TDepRight)e.OldItems[i];
                        var left = context.Trace.ResolveIn(childRule.RightToLeft, item);
                        if (left != null)
                        {
                            lefts.Remove(left);
                        }
                    }
                }
                if (e.NewItems != null)
                {
                    for (int i = 0; i < e.NewItems.Count; i++)
                    {
                        TDepRight item = (TDepRight)e.NewItems[i];
                        AddCorrespondingToLefts(lefts, context, item);
                    }
                }
            }
            else
            {
                var rightsSaved = new List<TDepRight>(rights);
                lefts.Clear();
                foreach (var item in rightsSaved)
                {
                    AddCorrespondingToLefts(lefts, context, item);
                }
            }
        }

        private void ProcessLeftChangesForRights(ICollection<TDepLeft> lefts, ICollection<TDepRight> rights, ISynchronizationContext context, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action != NotifyCollectionChangedAction.Reset)
            {
                if (e.OldItems != null)
                {
                    for (int i = e.OldItems.Count - 1; i >= 0; i--)
                    {
                        TDepLeft item = (TDepLeft)e.OldItems[i];
                        var right = context.Trace.ResolveIn(childRule.LeftToRight, item);
                        if (right != null)
                        {
                            rights.Remove(right);
                        }
                    }
                }
                if (e.NewItems != null)
                {
                    for (int i = 0; i < e.NewItems.Count; i++)
                    {
                        TDepLeft item = (TDepLeft)e.NewItems[i];
                        AddCorrespondingToRights(rights, context, item);
                    }
                }
            }
            else
            {
                var leftsSaved = new List<TDepLeft>(lefts);
                rights.Clear();
                foreach (var item in leftsSaved)
                {
                    AddCorrespondingToRights(rights, context, item);
                }
            }
        }

        private void AddCorrespondingToLefts(ICollection<TDepLeft> lefts, ISynchronizationContext context, TDepRight item)
        {
            var comp = context.CallTransformation(childRule.RightToLeft, new object[] { item }, lefts) as SynchronizationComputation<TDepRight, TDepLeft>;
            comp.DoWhenOutputIsAvailable((inp, outp) =>
            {
                lefts.Add(outp);
            });
        }

        private void AddCorrespondingToRights(ICollection<TDepRight> rights, ISynchronizationContext context, TDepLeft item)
        {
            var comp = context.CallTransformation(childRule.LeftToRight, new object[] { item }, rights) as SynchronizationComputation<TDepLeft, TDepRight>;
            comp.DoWhenOutputIsAvailable((inp, outp) =>
            {
                rights.Add(outp);
            });
        }

        private void SynchronizeRTLCollections(ICollection<TDepLeft> lefts, ICollection<TDepRight> rights, ISynchronizationContext context, bool ignoreCandidates, Queue<IDisposable> dependencies)
        {
            if (lefts != null)
            {
                if (lefts.IsReadOnly) throw new InvalidOperationException("Collection is read-only!");
                IEnumerable<TDepLeft> leftsSaved = lefts;
                if (rights == null || context.Direction == SynchronizationDirection.RightToLeftForced)
                {
                    leftsSaved = lefts.ToArray();
                    lefts.Clear();
                }
                var doubles = new HashSet<TDepLeft>();
                IEnumerable leftContext = ignoreCandidates ? null : lefts;
                foreach (var item in rights)
                {
                    var comp = context.CallTransformation(childRule.RightToLeft, new object[] { item }, leftContext) as SynchronizationComputation<TDepRight, TDepLeft>;
                    comp.DoWhenOutputIsAvailable((inp, outp) =>
                    {
                        if (!lefts.Contains(outp))
                        {
                            lefts.Add(outp);
                        }
                        else
                        {
                            doubles.Add(outp);
                        }
                    });
                }
                if (context.Direction == SynchronizationDirection.RightWins)
                {
                    foreach (var item in leftsSaved.Except(doubles))
                    {
                        AddCorrespondingToRights(rights, context, item);
                    }
                }
                RegisterRightChangePropagationHooks(lefts, rights, context, dependencies);
            }
            else
            {
                throw new NotSupportedException("Target collection must not be null!");
            }
        }

        public ITransformationRuleDependency CreateLeftToRightDependency()
        {
            return new LTRDependency(this);
        }

        public ITransformationRuleDependency CreateRightToLeftDependency()
        {
            return new RTLDependency(this);
        }

        private class LTRDependency : OutputDependency
        {
            private SynchronizationMultipleDependency<TLeft, TRight, TDepLeft, TDepRight> parent;

            public LTRDependency(SynchronizationMultipleDependency<TLeft, TRight, TDepLeft, TDepRight> parent)
            {
                this.parent = parent;
            }

            protected override void HandleReadyComputation(Computation computation)
            {
                parent.HandleLeftToRightDependency(computation);
            }
        }

        private class RTLDependency : OutputDependency
        {
            private SynchronizationMultipleDependency<TLeft, TRight, TDepLeft, TDepRight> parent;

            public RTLDependency(SynchronizationMultipleDependency<TLeft, TRight, TDepLeft, TDepRight> parent)
            {
                this.parent = parent;
            }

            protected override void HandleReadyComputation(Computation computation)
            {
                parent.HandleRightToLeftDependency(computation);
            }
        }

        private abstract class NotificationHook : IDisposable
        {
            public ICollection<TDepLeft> Lefts { get; private set; }
            public ICollection<TDepRight> Rights { get; private set; }
            public ISynchronizationContext Context { get; private set; }
            public SynchronizationMultipleDependency<TLeft, TRight, TDepLeft, TDepRight> Parent { get; private set; }

            public NotificationHook(ICollection<TDepLeft> lefts, ICollection<TDepRight> rights, ISynchronizationContext context, SynchronizationMultipleDependency<TLeft, TRight, TDepLeft, TDepRight> parent)
            {
                Lefts = lefts;
                Rights = rights;
                Context = context;
                Parent = parent;
            }

            public abstract void Dispose();
        }

        private class LeftToRightHook : NotificationHook
        {
            public LeftToRightHook(ICollection<TDepLeft> lefts, ICollection<TDepRight> rights, ISynchronizationContext context, SynchronizationMultipleDependency<TLeft, TRight, TDepLeft, TDepRight> parent)
                : base(lefts, rights, context, parent)
            {
                var notifier = lefts as INotifyCollectionChanged;
                if (notifier != null)
                {
                    notifier.CollectionChanged += LeftsChanged;
                }
            }

            private void LeftsChanged(object sender, NotifyCollectionChangedEventArgs e)
            {
                Parent.ProcessLeftChangesForRights(Lefts, Rights, Context, e);
            }

            public override void Dispose()
            {
                var notifier = Lefts as INotifyCollectionChanged;
                if (notifier != null)
                {
                    notifier.CollectionChanged -= LeftsChanged;
                }
            }
        }

        private class RightToLeftHook : NotificationHook
        {
            public RightToLeftHook(ICollection<TDepLeft> lefts, ICollection<TDepRight> rights, ISynchronizationContext context, SynchronizationMultipleDependency<TLeft, TRight, TDepLeft, TDepRight> parent)
                : base(lefts, rights, context, parent)
            {
                var notifier = rights as INotifyCollectionChanged;
                if (notifier != null)
                {
                    notifier.CollectionChanged += RightsChanged;
                }
            }

            private void RightsChanged(object sender, NotifyCollectionChangedEventArgs e)
            {
                Parent.ProcessRightChangesForLefts(Lefts, Rights, Context, e);
            }

            public override void Dispose()
            {
                var notifier = Lefts as INotifyCollectionChanged;
                if (notifier != null)
                {
                    notifier.CollectionChanged -= RightsChanged;
                }
            }
        }

        private class BidirectionalHook : NotificationHook
        {
            public BidirectionalHook(ICollection<TDepLeft> lefts, ICollection<TDepRight> rights, ISynchronizationContext context, SynchronizationMultipleDependency<TLeft, TRight, TDepLeft, TDepRight> parent)
                : base(lefts, rights, context, parent)
            {
                var leftNotifier = lefts as INotifyCollectionChanged;
                var rightNotifier = rights as INotifyCollectionChanged;
                if (leftNotifier != null)
                {
                    leftNotifier.CollectionChanged += LeftsChanged;
                }
                if (rightNotifier != null)
                {
                    rightNotifier.CollectionChanged += RightsChanged;
                }
            }

            private void LeftsChanged(object sender, NotifyCollectionChangedEventArgs e)
            {
                Parent.ProcessLeftChangesForRights(Lefts, Rights, Context, e);
            }

            private void RightsChanged(object sender, NotifyCollectionChangedEventArgs e)
            {
                Parent.ProcessRightChangesForLefts(Lefts, Rights, Context, e);
            }

            public override void Dispose()
            {
                var leftNotifier = Lefts as INotifyCollectionChanged;
                var rightNotifier = Rights as INotifyCollectionChanged;
                if (leftNotifier != null)
                {
                    leftNotifier.CollectionChanged -= LeftsChanged;
                }
                if (rightNotifier != null)
                {
                    rightNotifier.CollectionChanged -= RightsChanged;
                }
            }
        }
    }
}
