//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMF.Models.Meta
{
    
    
    /// <summary>
    /// The public interface for ReferenceConstraint
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ReferenceConstraint))]
    [XmlDefaultImplementationTypeAttribute(typeof(ReferenceConstraint))]
    public interface IReferenceConstraint : IModelElement
    {
        
        /// <summary>
        /// The DeclaringType property
        /// </summary>
        IClass DeclaringType
        {
            get;
            set;
        }
        
        /// <summary>
        /// The References property
        /// </summary>
        IListExpression<IModelElement> References
        {
            get;
        }
        
        /// <summary>
        /// The Constrains property
        /// </summary>
        IReference Constrains
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the DeclaringType property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DeclaringTypeChanging;
        
        /// <summary>
        /// Gets fired when the DeclaringType property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DeclaringTypeChanged;
        
        /// <summary>
        /// Gets fired before the Constrains property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ConstrainsChanging;
        
        /// <summary>
        /// Gets fired when the Constrains property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ConstrainsChanged;
    }
}

