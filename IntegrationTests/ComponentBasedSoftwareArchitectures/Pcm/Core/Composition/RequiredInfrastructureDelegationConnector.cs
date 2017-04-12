//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMFExamples.Pcm.Core;
using NMFExamples.Pcm.Core.Entity;
using NMFExamples.Pcm.Parameter;
using NMFExamples.Pcm.Repository;
using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using global::System.Collections;
using global::System.Collections.Generic;
using global::System.Collections.ObjectModel;
using global::System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMFExamples.Pcm.Core.Composition
{
    
    
    /// <summary>
    /// The default implementation of the RequiredInfrastructureDelegationConnector class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/Core/Composition/5.0")]
    [XmlNamespacePrefixAttribute("composition")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core/composition/RequiredInfra" +
        "structureDelegationConnector")]
    [DebuggerDisplayAttribute("RequiredInfrastructureDelegationConnector {Id}")]
    public partial class RequiredInfrastructureDelegationConnector : DelegationConnector, IRequiredInfrastructureDelegationConnector, IModelElement
    {
        
        private static Lazy<ITypedElement> _innerRequiredRole__RequiredInfrastructureDelegationConnectorReference = new Lazy<ITypedElement>(RetrieveInnerRequiredRole__RequiredInfrastructureDelegationConnectorReference);
        
        /// <summary>
        /// The backing field for the InnerRequiredRole__RequiredInfrastructureDelegationConnector property
        /// </summary>
        private IInfrastructureRequiredRole _innerRequiredRole__RequiredInfrastructureDelegationConnector;
        
        private static Lazy<ITypedElement> _outerRequiredRole__RequiredInfrastructureDelegationConnectorReference = new Lazy<ITypedElement>(RetrieveOuterRequiredRole__RequiredInfrastructureDelegationConnectorReference);
        
        /// <summary>
        /// The backing field for the OuterRequiredRole__RequiredInfrastructureDelegationConnector property
        /// </summary>
        private IInfrastructureRequiredRole _outerRequiredRole__RequiredInfrastructureDelegationConnector;
        
        private static Lazy<ITypedElement> _assemblyContext__RequiredInfrastructureDelegationConnectorReference = new Lazy<ITypedElement>(RetrieveAssemblyContext__RequiredInfrastructureDelegationConnectorReference);
        
        /// <summary>
        /// The backing field for the AssemblyContext__RequiredInfrastructureDelegationConnector property
        /// </summary>
        private IAssemblyContext _assemblyContext__RequiredInfrastructureDelegationConnector;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The innerRequiredRole__RequiredInfrastructureDelegationConnector property
        /// </summary>
        [XmlElementNameAttribute("innerRequiredRole__RequiredInfrastructureDelegationConnector")]
        [XmlAttributeAttribute(true)]
        public IInfrastructureRequiredRole InnerRequiredRole__RequiredInfrastructureDelegationConnector
        {
            get
            {
                return this._innerRequiredRole__RequiredInfrastructureDelegationConnector;
            }
            set
            {
                if ((this._innerRequiredRole__RequiredInfrastructureDelegationConnector != value))
                {
                    IInfrastructureRequiredRole old = this._innerRequiredRole__RequiredInfrastructureDelegationConnector;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnInnerRequiredRole__RequiredInfrastructureDelegationConnectorChanging(e);
                    this.OnPropertyChanging("InnerRequiredRole__RequiredInfrastructureDelegationConnector", e, _innerRequiredRole__RequiredInfrastructureDelegationConnectorReference);
                    this._innerRequiredRole__RequiredInfrastructureDelegationConnector = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetInnerRequiredRole__RequiredInfrastructureDelegationConnector;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetInnerRequiredRole__RequiredInfrastructureDelegationConnector;
                    }
                    this.OnInnerRequiredRole__RequiredInfrastructureDelegationConnectorChanged(e);
                    this.OnPropertyChanged("InnerRequiredRole__RequiredInfrastructureDelegationConnector", e, _innerRequiredRole__RequiredInfrastructureDelegationConnectorReference);
                }
            }
        }
        
        /// <summary>
        /// The outerRequiredRole__RequiredInfrastructureDelegationConnector property
        /// </summary>
        [XmlElementNameAttribute("outerRequiredRole__RequiredInfrastructureDelegationConnector")]
        [XmlAttributeAttribute(true)]
        public IInfrastructureRequiredRole OuterRequiredRole__RequiredInfrastructureDelegationConnector
        {
            get
            {
                return this._outerRequiredRole__RequiredInfrastructureDelegationConnector;
            }
            set
            {
                if ((this._outerRequiredRole__RequiredInfrastructureDelegationConnector != value))
                {
                    IInfrastructureRequiredRole old = this._outerRequiredRole__RequiredInfrastructureDelegationConnector;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnOuterRequiredRole__RequiredInfrastructureDelegationConnectorChanging(e);
                    this.OnPropertyChanging("OuterRequiredRole__RequiredInfrastructureDelegationConnector", e, _outerRequiredRole__RequiredInfrastructureDelegationConnectorReference);
                    this._outerRequiredRole__RequiredInfrastructureDelegationConnector = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetOuterRequiredRole__RequiredInfrastructureDelegationConnector;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetOuterRequiredRole__RequiredInfrastructureDelegationConnector;
                    }
                    this.OnOuterRequiredRole__RequiredInfrastructureDelegationConnectorChanged(e);
                    this.OnPropertyChanged("OuterRequiredRole__RequiredInfrastructureDelegationConnector", e, _outerRequiredRole__RequiredInfrastructureDelegationConnectorReference);
                }
            }
        }
        
        /// <summary>
        /// The assemblyContext__RequiredInfrastructureDelegationConnector property
        /// </summary>
        [XmlElementNameAttribute("assemblyContext__RequiredInfrastructureDelegationConnector")]
        [XmlAttributeAttribute(true)]
        public IAssemblyContext AssemblyContext__RequiredInfrastructureDelegationConnector
        {
            get
            {
                return this._assemblyContext__RequiredInfrastructureDelegationConnector;
            }
            set
            {
                if ((this._assemblyContext__RequiredInfrastructureDelegationConnector != value))
                {
                    IAssemblyContext old = this._assemblyContext__RequiredInfrastructureDelegationConnector;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnAssemblyContext__RequiredInfrastructureDelegationConnectorChanging(e);
                    this.OnPropertyChanging("AssemblyContext__RequiredInfrastructureDelegationConnector", e, _assemblyContext__RequiredInfrastructureDelegationConnectorReference);
                    this._assemblyContext__RequiredInfrastructureDelegationConnector = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetAssemblyContext__RequiredInfrastructureDelegationConnector;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetAssemblyContext__RequiredInfrastructureDelegationConnector;
                    }
                    this.OnAssemblyContext__RequiredInfrastructureDelegationConnectorChanged(e);
                    this.OnPropertyChanged("AssemblyContext__RequiredInfrastructureDelegationConnector", e, _assemblyContext__RequiredInfrastructureDelegationConnectorReference);
                }
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new RequiredInfrastructureDelegationConnectorReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core/composition/RequiredInfra" +
                            "structureDelegationConnector")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the InnerRequiredRole__RequiredInfrastructureDelegationConnector property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> InnerRequiredRole__RequiredInfrastructureDelegationConnectorChanging;
        
        /// <summary>
        /// Gets fired when the InnerRequiredRole__RequiredInfrastructureDelegationConnector property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> InnerRequiredRole__RequiredInfrastructureDelegationConnectorChanged;
        
        /// <summary>
        /// Gets fired before the OuterRequiredRole__RequiredInfrastructureDelegationConnector property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> OuterRequiredRole__RequiredInfrastructureDelegationConnectorChanging;
        
        /// <summary>
        /// Gets fired when the OuterRequiredRole__RequiredInfrastructureDelegationConnector property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> OuterRequiredRole__RequiredInfrastructureDelegationConnectorChanged;
        
        /// <summary>
        /// Gets fired before the AssemblyContext__RequiredInfrastructureDelegationConnector property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> AssemblyContext__RequiredInfrastructureDelegationConnectorChanging;
        
        /// <summary>
        /// Gets fired when the AssemblyContext__RequiredInfrastructureDelegationConnector property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> AssemblyContext__RequiredInfrastructureDelegationConnectorChanged;
        
        private static ITypedElement RetrieveInnerRequiredRole__RequiredInfrastructureDelegationConnectorReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Core.Composition.RequiredInfrastructureDelegationConnector.ClassInstance)).Resolve("innerRequiredRole__RequiredInfrastructureDelegationConnector")));
        }
        
        /// <summary>
        /// Raises the InnerRequiredRole__RequiredInfrastructureDelegationConnectorChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnInnerRequiredRole__RequiredInfrastructureDelegationConnectorChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.InnerRequiredRole__RequiredInfrastructureDelegationConnectorChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the InnerRequiredRole__RequiredInfrastructureDelegationConnectorChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnInnerRequiredRole__RequiredInfrastructureDelegationConnectorChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.InnerRequiredRole__RequiredInfrastructureDelegationConnectorChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the InnerRequiredRole__RequiredInfrastructureDelegationConnector property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetInnerRequiredRole__RequiredInfrastructureDelegationConnector(object sender, global::System.EventArgs eventArgs)
        {
            this.InnerRequiredRole__RequiredInfrastructureDelegationConnector = null;
        }
        
        private static ITypedElement RetrieveOuterRequiredRole__RequiredInfrastructureDelegationConnectorReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Core.Composition.RequiredInfrastructureDelegationConnector.ClassInstance)).Resolve("outerRequiredRole__RequiredInfrastructureDelegationConnector")));
        }
        
        /// <summary>
        /// Raises the OuterRequiredRole__RequiredInfrastructureDelegationConnectorChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOuterRequiredRole__RequiredInfrastructureDelegationConnectorChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.OuterRequiredRole__RequiredInfrastructureDelegationConnectorChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the OuterRequiredRole__RequiredInfrastructureDelegationConnectorChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOuterRequiredRole__RequiredInfrastructureDelegationConnectorChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.OuterRequiredRole__RequiredInfrastructureDelegationConnectorChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the OuterRequiredRole__RequiredInfrastructureDelegationConnector property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetOuterRequiredRole__RequiredInfrastructureDelegationConnector(object sender, global::System.EventArgs eventArgs)
        {
            this.OuterRequiredRole__RequiredInfrastructureDelegationConnector = null;
        }
        
        private static ITypedElement RetrieveAssemblyContext__RequiredInfrastructureDelegationConnectorReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Core.Composition.RequiredInfrastructureDelegationConnector.ClassInstance)).Resolve("assemblyContext__RequiredInfrastructureDelegationConnector")));
        }
        
        /// <summary>
        /// Raises the AssemblyContext__RequiredInfrastructureDelegationConnectorChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAssemblyContext__RequiredInfrastructureDelegationConnectorChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.AssemblyContext__RequiredInfrastructureDelegationConnectorChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the AssemblyContext__RequiredInfrastructureDelegationConnectorChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAssemblyContext__RequiredInfrastructureDelegationConnectorChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.AssemblyContext__RequiredInfrastructureDelegationConnectorChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the AssemblyContext__RequiredInfrastructureDelegationConnector property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetAssemblyContext__RequiredInfrastructureDelegationConnector(object sender, global::System.EventArgs eventArgs)
        {
            this.AssemblyContext__RequiredInfrastructureDelegationConnector = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "INNERREQUIREDROLE__REQUIREDINFRASTRUCTUREDELEGATIONCONNECTOR"))
            {
                this.InnerRequiredRole__RequiredInfrastructureDelegationConnector = ((IInfrastructureRequiredRole)(value));
                return;
            }
            if ((feature == "OUTERREQUIREDROLE__REQUIREDINFRASTRUCTUREDELEGATIONCONNECTOR"))
            {
                this.OuterRequiredRole__RequiredInfrastructureDelegationConnector = ((IInfrastructureRequiredRole)(value));
                return;
            }
            if ((feature == "ASSEMBLYCONTEXT__REQUIREDINFRASTRUCTUREDELEGATIONCONNECTOR"))
            {
                this.AssemblyContext__RequiredInfrastructureDelegationConnector = ((IAssemblyContext)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given attribute
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="attribute">The requested attribute in upper case</param>
        protected override NMF.Expressions.INotifyExpression<object> GetExpressionForAttribute(string attribute)
        {
            if ((attribute == "InnerRequiredRole__RequiredInfrastructureDelegationConnector"))
            {
                return new InnerRequiredRole__RequiredInfrastructureDelegationConnectorProxy(this);
            }
            if ((attribute == "OuterRequiredRole__RequiredInfrastructureDelegationConnector"))
            {
                return new OuterRequiredRole__RequiredInfrastructureDelegationConnectorProxy(this);
            }
            if ((attribute == "AssemblyContext__RequiredInfrastructureDelegationConnector"))
            {
                return new AssemblyContext__RequiredInfrastructureDelegationConnectorProxy(this);
            }
            return base.GetExpressionForAttribute(attribute);
        }
        
        /// <summary>
        /// Gets the property expression for the given reference
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="reference">The requested reference in upper case</param>
        protected override NMF.Expressions.INotifyExpression<NMF.Models.IModelElement> GetExpressionForReference(string reference)
        {
            if ((reference == "InnerRequiredRole__RequiredInfrastructureDelegationConnector"))
            {
                return new InnerRequiredRole__RequiredInfrastructureDelegationConnectorProxy(this);
            }
            if ((reference == "OuterRequiredRole__RequiredInfrastructureDelegationConnector"))
            {
                return new OuterRequiredRole__RequiredInfrastructureDelegationConnectorProxy(this);
            }
            if ((reference == "AssemblyContext__RequiredInfrastructureDelegationConnector"))
            {
                return new AssemblyContext__RequiredInfrastructureDelegationConnectorProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core/composition/RequiredInfra" +
                        "structureDelegationConnector")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the RequiredInfrastructureDelegationConnector class
        /// </summary>
        public class RequiredInfrastructureDelegationConnectorReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private RequiredInfrastructureDelegationConnector _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public RequiredInfrastructureDelegationConnectorReferencedElementsCollection(RequiredInfrastructureDelegationConnector parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    if ((this._parent.InnerRequiredRole__RequiredInfrastructureDelegationConnector != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.OuterRequiredRole__RequiredInfrastructureDelegationConnector != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.AssemblyContext__RequiredInfrastructureDelegationConnector != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.InnerRequiredRole__RequiredInfrastructureDelegationConnectorChanged += this.PropagateValueChanges;
                this._parent.OuterRequiredRole__RequiredInfrastructureDelegationConnectorChanged += this.PropagateValueChanges;
                this._parent.AssemblyContext__RequiredInfrastructureDelegationConnectorChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.InnerRequiredRole__RequiredInfrastructureDelegationConnectorChanged -= this.PropagateValueChanges;
                this._parent.OuterRequiredRole__RequiredInfrastructureDelegationConnectorChanged -= this.PropagateValueChanges;
                this._parent.AssemblyContext__RequiredInfrastructureDelegationConnectorChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.InnerRequiredRole__RequiredInfrastructureDelegationConnector == null))
                {
                    IInfrastructureRequiredRole innerRequiredRole__RequiredInfrastructureDelegationConnectorCasted = item.As<IInfrastructureRequiredRole>();
                    if ((innerRequiredRole__RequiredInfrastructureDelegationConnectorCasted != null))
                    {
                        this._parent.InnerRequiredRole__RequiredInfrastructureDelegationConnector = innerRequiredRole__RequiredInfrastructureDelegationConnectorCasted;
                        return;
                    }
                }
                if ((this._parent.OuterRequiredRole__RequiredInfrastructureDelegationConnector == null))
                {
                    IInfrastructureRequiredRole outerRequiredRole__RequiredInfrastructureDelegationConnectorCasted = item.As<IInfrastructureRequiredRole>();
                    if ((outerRequiredRole__RequiredInfrastructureDelegationConnectorCasted != null))
                    {
                        this._parent.OuterRequiredRole__RequiredInfrastructureDelegationConnector = outerRequiredRole__RequiredInfrastructureDelegationConnectorCasted;
                        return;
                    }
                }
                if ((this._parent.AssemblyContext__RequiredInfrastructureDelegationConnector == null))
                {
                    IAssemblyContext assemblyContext__RequiredInfrastructureDelegationConnectorCasted = item.As<IAssemblyContext>();
                    if ((assemblyContext__RequiredInfrastructureDelegationConnectorCasted != null))
                    {
                        this._parent.AssemblyContext__RequiredInfrastructureDelegationConnector = assemblyContext__RequiredInfrastructureDelegationConnectorCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.InnerRequiredRole__RequiredInfrastructureDelegationConnector = null;
                this._parent.OuterRequiredRole__RequiredInfrastructureDelegationConnector = null;
                this._parent.AssemblyContext__RequiredInfrastructureDelegationConnector = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.InnerRequiredRole__RequiredInfrastructureDelegationConnector))
                {
                    return true;
                }
                if ((item == this._parent.OuterRequiredRole__RequiredInfrastructureDelegationConnector))
                {
                    return true;
                }
                if ((item == this._parent.AssemblyContext__RequiredInfrastructureDelegationConnector))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                if ((this._parent.InnerRequiredRole__RequiredInfrastructureDelegationConnector != null))
                {
                    array[arrayIndex] = this._parent.InnerRequiredRole__RequiredInfrastructureDelegationConnector;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.OuterRequiredRole__RequiredInfrastructureDelegationConnector != null))
                {
                    array[arrayIndex] = this._parent.OuterRequiredRole__RequiredInfrastructureDelegationConnector;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.AssemblyContext__RequiredInfrastructureDelegationConnector != null))
                {
                    array[arrayIndex] = this._parent.AssemblyContext__RequiredInfrastructureDelegationConnector;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.InnerRequiredRole__RequiredInfrastructureDelegationConnector == item))
                {
                    this._parent.InnerRequiredRole__RequiredInfrastructureDelegationConnector = null;
                    return true;
                }
                if ((this._parent.OuterRequiredRole__RequiredInfrastructureDelegationConnector == item))
                {
                    this._parent.OuterRequiredRole__RequiredInfrastructureDelegationConnector = null;
                    return true;
                }
                if ((this._parent.AssemblyContext__RequiredInfrastructureDelegationConnector == item))
                {
                    this._parent.AssemblyContext__RequiredInfrastructureDelegationConnector = null;
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.InnerRequiredRole__RequiredInfrastructureDelegationConnector).Concat(this._parent.OuterRequiredRole__RequiredInfrastructureDelegationConnector).Concat(this._parent.AssemblyContext__RequiredInfrastructureDelegationConnector).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the innerRequiredRole__RequiredInfrastructureDelegationConnector property
        /// </summary>
        private sealed class InnerRequiredRole__RequiredInfrastructureDelegationConnectorProxy : ModelPropertyChange<IRequiredInfrastructureDelegationConnector, IInfrastructureRequiredRole>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public InnerRequiredRole__RequiredInfrastructureDelegationConnectorProxy(IRequiredInfrastructureDelegationConnector modelElement) : 
                    base(modelElement, "innerRequiredRole__RequiredInfrastructureDelegationConnector")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IInfrastructureRequiredRole Value
            {
                get
                {
                    return this.ModelElement.InnerRequiredRole__RequiredInfrastructureDelegationConnector;
                }
                set
                {
                    this.ModelElement.InnerRequiredRole__RequiredInfrastructureDelegationConnector = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the outerRequiredRole__RequiredInfrastructureDelegationConnector property
        /// </summary>
        private sealed class OuterRequiredRole__RequiredInfrastructureDelegationConnectorProxy : ModelPropertyChange<IRequiredInfrastructureDelegationConnector, IInfrastructureRequiredRole>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OuterRequiredRole__RequiredInfrastructureDelegationConnectorProxy(IRequiredInfrastructureDelegationConnector modelElement) : 
                    base(modelElement, "outerRequiredRole__RequiredInfrastructureDelegationConnector")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IInfrastructureRequiredRole Value
            {
                get
                {
                    return this.ModelElement.OuterRequiredRole__RequiredInfrastructureDelegationConnector;
                }
                set
                {
                    this.ModelElement.OuterRequiredRole__RequiredInfrastructureDelegationConnector = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the assemblyContext__RequiredInfrastructureDelegationConnector property
        /// </summary>
        private sealed class AssemblyContext__RequiredInfrastructureDelegationConnectorProxy : ModelPropertyChange<IRequiredInfrastructureDelegationConnector, IAssemblyContext>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public AssemblyContext__RequiredInfrastructureDelegationConnectorProxy(IRequiredInfrastructureDelegationConnector modelElement) : 
                    base(modelElement, "assemblyContext__RequiredInfrastructureDelegationConnector")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IAssemblyContext Value
            {
                get
                {
                    return this.ModelElement.AssemblyContext__RequiredInfrastructureDelegationConnector;
                }
                set
                {
                    this.ModelElement.AssemblyContext__RequiredInfrastructureDelegationConnector = value;
                }
            }
        }
    }
}
