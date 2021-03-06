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
using NMFExamples.Pcm.Protocol;
using NMFExamples.Pcm.Reliability;
using NMFExamples.Pcm.Resourcetype;
using NMFExamples.Pcm.Seff;
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
using System.Globalization;
using System.Linq;

namespace NMFExamples.Pcm.Repository
{
    
    
    /// <summary>
    /// The public interface for EventType
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(EventType))]
    [XmlDefaultImplementationTypeAttribute(typeof(EventType))]
    public interface IEventType : IModelElement, ISignature
    {
        
        /// <summary>
        /// The parameter__EventType property
        /// </summary>
        IParameter Parameter__EventType
        {
            get;
            set;
        }
        
        /// <summary>
        /// The eventGroup__EventType property
        /// </summary>
        IEventGroup EventGroup__EventType
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Parameter__EventType property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> Parameter__EventTypeChanging;
        
        /// <summary>
        /// Gets fired when the Parameter__EventType property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> Parameter__EventTypeChanged;
        
        /// <summary>
        /// Gets fired before the EventGroup__EventType property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> EventGroup__EventTypeChanging;
        
        /// <summary>
        /// Gets fired when the EventGroup__EventType property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> EventGroup__EventTypeChanged;
    }
}

