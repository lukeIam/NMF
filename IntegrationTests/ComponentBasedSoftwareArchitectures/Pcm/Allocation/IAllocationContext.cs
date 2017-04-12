//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMFExamples.Pcm.Core.Composition;
using NMFExamples.Pcm.Core.Entity;
using NMFExamples.Pcm.Resourceenvironment;
using NMFExamples.Pcm.System;
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

namespace NMFExamples.Pcm.Allocation
{
    
    
    /// <summary>
    /// The public interface for AllocationContext
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(AllocationContext))]
    [XmlDefaultImplementationTypeAttribute(typeof(AllocationContext))]
    public interface IAllocationContext : IModelElement, IEntity
    {
        
        /// <summary>
        /// The resourceContainer_AllocationContext property
        /// </summary>
        IResourceContainer ResourceContainer_AllocationContext
        {
            get;
            set;
        }
        
        /// <summary>
        /// The assemblyContext_AllocationContext property
        /// </summary>
        IAssemblyContext AssemblyContext_AllocationContext
        {
            get;
            set;
        }
        
        /// <summary>
        /// The allocation_AllocationContext property
        /// </summary>
        IAllocation Allocation_AllocationContext
        {
            get;
            set;
        }
        
        /// <summary>
        /// The eventChannel__AllocationContext property
        /// </summary>
        IEventChannel EventChannel__AllocationContext
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the ResourceContainer_AllocationContext property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> ResourceContainer_AllocationContextChanging;
        
        /// <summary>
        /// Gets fired when the ResourceContainer_AllocationContext property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> ResourceContainer_AllocationContextChanged;
        
        /// <summary>
        /// Gets fired before the AssemblyContext_AllocationContext property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> AssemblyContext_AllocationContextChanging;
        
        /// <summary>
        /// Gets fired when the AssemblyContext_AllocationContext property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> AssemblyContext_AllocationContextChanged;
        
        /// <summary>
        /// Gets fired before the Allocation_AllocationContext property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> Allocation_AllocationContextChanging;
        
        /// <summary>
        /// Gets fired when the Allocation_AllocationContext property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> Allocation_AllocationContextChanged;
        
        /// <summary>
        /// Gets fired before the EventChannel__AllocationContext property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> EventChannel__AllocationContextChanging;
        
        /// <summary>
        /// Gets fired when the EventChannel__AllocationContext property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> EventChannel__AllocationContextChanged;
    }
}
