//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMFExamples.Pcm.Core.Entity;
using NMFExamples.Pcm.Parameter;
using NMFExamples.Pcm.Repository;
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

namespace NMFExamples.Pcm.Qosannotations
{
    
    
    public class SpecifiedOutputParameterAbstractionExpectedExternalOutputs_SpecifiedOutputParameterAbstractionCollection : ObservableOppositeList<ISpecifiedOutputParameterAbstraction, IVariableUsage>
    {
        
        public SpecifiedOutputParameterAbstractionExpectedExternalOutputs_SpecifiedOutputParameterAbstractionCollection(ISpecifiedOutputParameterAbstraction parent) : 
                base(parent)
        {
        }
        
        private void OnItemParentChanged(object sender, ValueChangedEventArgs e)
        {
            if ((e.NewValue != this.Parent))
            {
                this.Remove(((IVariableUsage)(sender)));
            }
        }
        
        protected override void SetOpposite(IVariableUsage item, ISpecifiedOutputParameterAbstraction parent)
        {
            if ((parent != null))
            {
                item.ParentChanged += this.OnItemParentChanged;
                item.SpecifiedOutputParameterAbstraction_expectedExternalOutputs_VariableUsage = parent;
            }
            else
            {
                item.ParentChanged -= this.OnItemParentChanged;
                if ((item.SpecifiedOutputParameterAbstraction_expectedExternalOutputs_VariableUsage == this.Parent))
                {
                    item.SpecifiedOutputParameterAbstraction_expectedExternalOutputs_VariableUsage = parent;
                }
            }
        }
    }
}
