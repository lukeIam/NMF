//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.34209
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
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMF.Interop.Ecore
{
    
    
    /// <summary>
    /// The public interface for ENamedElement
    /// </summary>
    [XmlIdentifierAttribute("name")]
    [XmlNamespaceAttribute("http://www.eclipse.org/emf/2002/Ecore")]
    [XmlNamespacePrefixAttribute("ecore")]
    [ModelRepresentationClassAttribute("http://www.eclipse.org/emf/2002/Ecore#//ENamedElement/")]
    [XmlDefaultImplementationTypeAttribute(typeof(ENamedElement))]
    [DefaultImplementationTypeAttribute(typeof(ENamedElement))]
    public interface IENamedElement : IModelElement, IEModelElement
    {
        
        /// <summary>
        /// The name property
        /// </summary>
        string Name
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the Name property changed its value
        /// </summary>
        event EventHandler NameChanged;
    }
}
