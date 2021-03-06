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
using NMFExamples.Pcm.Core.Composition;
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

namespace NMFExamples.Pcm.Usagemodel
{
    
    
    /// <summary>
    /// The public interface for UsageScenario
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(UsageScenario))]
    [XmlDefaultImplementationTypeAttribute(typeof(UsageScenario))]
    public interface IUsageScenario : IModelElement, IEntity
    {
        
        /// <summary>
        /// The usageModel_UsageScenario property
        /// </summary>
        IUsageModel UsageModel_UsageScenario
        {
            get;
            set;
        }
        
        /// <summary>
        /// The scenarioBehaviour_UsageScenario property
        /// </summary>
        IScenarioBehaviour ScenarioBehaviour_UsageScenario
        {
            get;
            set;
        }
        
        /// <summary>
        /// The workload_UsageScenario property
        /// </summary>
        IWorkload Workload_UsageScenario
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the UsageModel_UsageScenario property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> UsageModel_UsageScenarioChanging;
        
        /// <summary>
        /// Gets fired when the UsageModel_UsageScenario property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> UsageModel_UsageScenarioChanged;
        
        /// <summary>
        /// Gets fired before the ScenarioBehaviour_UsageScenario property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> ScenarioBehaviour_UsageScenarioChanging;
        
        /// <summary>
        /// Gets fired when the ScenarioBehaviour_UsageScenario property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> ScenarioBehaviour_UsageScenarioChanged;
        
        /// <summary>
        /// Gets fired before the Workload_UsageScenario property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> Workload_UsageScenarioChanging;
        
        /// <summary>
        /// Gets fired when the Workload_UsageScenario property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> Workload_UsageScenarioChanged;
    }
}

