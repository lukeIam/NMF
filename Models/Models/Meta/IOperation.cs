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
    /// The public interface for Operation
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Operation))]
    [XmlDefaultImplementationTypeAttribute(typeof(Operation))]
    public interface IOperation : IModelElement, ITypedElement
    {
        
        /// <summary>
        /// The Parameters property
        /// </summary>
        ICollectionExpression<IParameter> Parameters
        {
            get;
        }
        
        /// <summary>
        /// The DeclaringType property
        /// </summary>
        IStructuredType DeclaringType
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Refines property
        /// </summary>
        IOperation Refines
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
        /// Gets fired before the Refines property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RefinesChanging;
        
        /// <summary>
        /// Gets fired when the Refines property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RefinesChanged;
    }
}

