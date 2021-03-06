﻿using NMF.Collections.Generic;
using NMF.Expressions;
using NMF.Expressions.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;

namespace NMF.Collections.ObjectModel
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix"), DebuggerDisplay("Count = {Count}"), DebuggerTypeProxy(typeof(EnumerableDebuggerProxy<>))]
    public class ObservableOrderedSet<T> : OrderedSet<T>, INotifyCollectionChanged, INotifyCollectionChanging, INotifyPropertyChanged, IOrderedSetExpression<T>, ICollectionExpression
    {
        protected void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        protected void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged("Count");
            OnPropertyChanged("Item[]");
            if (CollectionChanged != null) CollectionChanged(this, e);
        }

        protected void OnCollectionChanging(NotifyCollectionChangingEventArgs e)
        {
            CollectionChanging?.Invoke(this, e);
        }

        protected override void OnClearing(ref bool cancel)
        {
            base.OnClearing(ref cancel);
            if (!cancel)
                OnCollectionChanging(new NotifyCollectionChangingEventArgs(NotifyCollectionChangedAction.Reset));
        }

        protected override void OnCleared()
        {
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }

        protected override void OnInsertingItem(T item, ref bool cancel, int index)
        {
            if (!cancel)
                OnCollectionChanging(new NotifyCollectionChangingEventArgs(NotifyCollectionChangedAction.Add));
        }

        protected override void OnInsertItem(T item, int index)
        {
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item, index));
        }

        protected override void OnRemovingItem(T item, ref bool cancel, int index)
        {
            base.OnRemovingItem(item, ref cancel, index);
            if (!cancel)
                OnCollectionChanging(new NotifyCollectionChangingEventArgs(NotifyCollectionChangedAction.Remove));
        }

        protected override void OnRemoveItem(T item, int index)
        {
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item, index));
        }

        protected override void OnReplacingItem(T oldItem, T newItem, ref bool cancel)
        {
            base.OnReplacingItem(oldItem, newItem, ref cancel);
            if (!cancel)
                OnCollectionChanging(new NotifyCollectionChangingEventArgs(NotifyCollectionChangedAction.Replace));
        }

        protected override void OnReplaceItem(T oldItem, T newItem, int index)
        {
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, newItem, oldItem, index));
        }

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public event EventHandler<NotifyCollectionChangingEventArgs> CollectionChanging;
        
        public event PropertyChangedEventHandler PropertyChanged;

        private INotifyCollection<T> proxy;

        public INotifyCollection<T> AsNotifiable()
        {
            if (proxy == null) proxy = this.WithUpdates();
            return proxy;
        }

        INotifyEnumerable<T> IEnumerableExpression<T>.AsNotifiable()
        {
            return AsNotifiable();
        }

        INotifyEnumerable IEnumerableExpression.AsNotifiable()
        {
            return AsNotifiable();
        }
    }
}
