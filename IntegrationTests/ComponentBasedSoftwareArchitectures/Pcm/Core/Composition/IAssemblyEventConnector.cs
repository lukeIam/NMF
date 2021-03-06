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
    /// The public interface for AssemblyEventConnector
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(AssemblyEventConnector))]
    [XmlDefaultImplementationTypeAttribute(typeof(AssemblyEventConnector))]
    public interface IAssemblyEventConnector : IModelElement, IConnector
    {
        
        /// <summary>
        /// The sinkRole__AssemblyEventConnector property
        /// </summary>
        ISinkRole SinkRole__AssemblyEventConnector
        {
            get;
            set;
        }
        
        /// <summary>
        /// The sourceRole__AssemblyEventConnector property
        /// </summary>
        ISourceRole SourceRole__AssemblyEventConnector
        {
            get;
            set;
        }
        
        /// <summary>
        /// The sinkAssemblyContext__AssemblyEventConnector property
        /// </summary>
        IAssemblyContext SinkAssemblyContext__AssemblyEventConnector
        {
            get;
            set;
        }
        
        /// <summary>
        /// The sourceAssemblyContext__AssemblyEventConnector property
        /// </summary>
        IAssemblyContext SourceAssemblyContext__AssemblyEventConnector
        {
            get;
            set;
        }
        
        /// <summary>
        /// The filterCondition__AssemblyEventConnector property
        /// </summary>
        IPCMRandomVariable FilterCondition__AssemblyEventConnector
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the SinkRole__AssemblyEventConnector property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> SinkRole__AssemblyEventConnectorChanging;
        
        /// <summary>
        /// Gets fired when the SinkRole__AssemblyEventConnector property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> SinkRole__AssemblyEventConnectorChanged;
        
        /// <summary>
        /// Gets fired before the SourceRole__AssemblyEventConnector property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> SourceRole__AssemblyEventConnectorChanging;
        
        /// <summary>
        /// Gets fired when the SourceRole__AssemblyEventConnector property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> SourceRole__AssemblyEventConnectorChanged;
        
        /// <summary>
        /// Gets fired before the SinkAssemblyContext__AssemblyEventConnector property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> SinkAssemblyContext__AssemblyEventConnectorChanging;
        
        /// <summary>
        /// Gets fired when the SinkAssemblyContext__AssemblyEventConnector property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> SinkAssemblyContext__AssemblyEventConnectorChanged;
        
        /// <summary>
        /// Gets fired before the SourceAssemblyContext__AssemblyEventConnector property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> SourceAssemblyContext__AssemblyEventConnectorChanging;
        
        /// <summary>
        /// Gets fired when the SourceAssemblyContext__AssemblyEventConnector property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> SourceAssemblyContext__AssemblyEventConnectorChanged;
        
        /// <summary>
        /// Gets fired before the FilterCondition__AssemblyEventConnector property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> FilterCondition__AssemblyEventConnectorChanging;
        
        /// <summary>
        /// Gets fired when the FilterCondition__AssemblyEventConnector property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> FilterCondition__AssemblyEventConnectorChanged;
    }
}

