﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq.Expressions;

namespace NMF.Expressions
{
    /// <summary>
    /// The common base class for incremental expressions
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class NotifyExpression<T> : NotifyExpressionBase, INotifyExpression<T>
    {
        /// <summary>
        /// Creates a new incremental expression
        /// </summary>
        protected NotifyExpression()
        {
            Successors.Attached += (obj, e) => Attach();
            Successors.Detached += (obj, e) => Detach();
        }

        /// <summary>
        /// Creates a new incremental expression with the given initial value
        /// </summary>
        /// <param name="value">The initial value</param>
        protected NotifyExpression(T value) : this()
        {
            this.value = value;
        }

        
        private T value;

        public event EventHandler<ValueChangedEventArgs> ValueChanged;

        /// <summary>
        /// Gets the current value of this expression
        /// </summary>
        public T Value { get { return value; } }

        /// <summary>
        /// Gets the current value as object
        /// </summary>
        public object ValueObject { get { return Value; } }

        /// <summary>
        /// Gets the type of this incremental expression
        /// </summary>
        public sealed override Type Type { get { return typeof(T); } }

        /// <summary>
        /// Determines whether this expression can be reduced
        /// </summary>
        public override bool CanReduce { get { return CanBeConstant; } }

        /// <summary>
        /// Returns whether the current expression can be constant
        /// </summary>
        public virtual bool CanBeConstant { get { return false; } }

        /// <summary>
        /// Gets the value of the current incremental expression
        /// </summary>
        /// <returns>The current value</returns>
        protected abstract T GetValue();

        /// <summary>
        /// Returns whether this expression is parameter free
        /// </summary>
        public abstract bool IsParameterFree { get; }

        /// <summary>
        /// Returns whether this expression is a constant value
        /// </summary>
        public virtual bool IsConstant
        {
            get { return false; }
        }

        public virtual ISuccessorList Successors { get; } = NotifySystem.DefaultSystem.CreateSuccessorList();

        public abstract IEnumerable<INotifiable> Dependencies { get; }

        public ExecutionMetaData ExecutionMetaData { get; } = new ExecutionMetaData();

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            Successors.UnsetAll();
        }

        private void Attach()
        {
            foreach (var dep in Dependencies)
                dep.Successors.Set(this);
            OnAttach();
            value = GetValue();
        }

        private void Detach()
        {
            OnDetach();
            foreach (var dep in Dependencies)
                dep.Successors.Unset(this);
        }

        /// <summary>
        /// Occurs when this node gets (re)attached to another node for the first time
        /// </summary>
        protected virtual void OnAttach() { }

        /// <summary>
        /// Occurs when the last successor of this node gets removed
        /// </summary>
        protected virtual void OnDetach() { }

        /// <summary>
        /// Simplifies the current expression
        /// </summary>
        /// <returns>A simpler expression representing the same incremental value (e.g. a constant if this expression can be constant), otherwise itself</returns>
        public new virtual INotifyExpression<T> Reduce()
        {
            Attach();
            if (CanBeConstant)
            {
                return new ObservableConstant<T>(Value);
            }
            else
            {
                return this;
            }
        }

        /// <summary>
        /// Simplifies the current expression
        /// </summary>
        /// <returns>A simpler expression representing the same incremental value (e.g. a constant if this expression can be constant), otherwise itself</returns>
        protected override Expression BaseReduce()
        {
            Attach();
            if (CanBeConstant)
            {
                return new ObservableConstant<T>(Value);
            }
            else
            {
                return this;
            }            
        }

        /// <summary>
        /// Gets called when the value of the current expression changes
        /// </summary>
        /// <param name="oldVal">The old value</param>
        /// <param name="newVal">The new value</param>
        protected void OnValueChanged(T oldVal, T newVal)
        {
            OnValueChanged(new ValueChangedEventArgs(oldVal, newVal));
        }


        /// <summary>
        /// Gets called when the value of the current expression changes
        /// </summary>
        /// <param name="e">The event data</param>
        protected virtual void OnValueChanged(ValueChangedEventArgs e)
        {
            var handler = ValueChanged;
            if (handler != null)
            {
                handler.Invoke(this, e);
            }
        }

        /// <summary>
        /// Refreshes the current value
        /// </summary>
        public virtual INotificationResult Notify(IList<INotificationResult> sources)
        {
            var newVal = GetValue();
            if (!EqualityComparer<T>.Default.Equals(value, newVal))
            {
                var oldVal = value;
                value = newVal;
                OnValueChanged(oldVal, newVal);
                return new ValueChangedNotificationResult<T>(this, oldVal, newVal);
            }
            return UnchangedNotificationResult.Instance;
        }

        /// <summary>
        /// Applies the given set of parameters to the expression
        /// </summary>
        /// <param name="parameters">A set of parameter values</param>
        /// <returns>A new expression with all parameter placeholders replaced with the parameter values</returns>
        /// <remarks>In case that the current expression is parameter free, it simply returns itself</remarks>
        public abstract INotifyExpression<T> ApplyParameters(IDictionary<string, object> parameters);

        INotifyExpression INotifyExpression.ApplyParameters(IDictionary<string, object> parameters)
        {
            return ApplyParameters(parameters);
        }
    }
}
