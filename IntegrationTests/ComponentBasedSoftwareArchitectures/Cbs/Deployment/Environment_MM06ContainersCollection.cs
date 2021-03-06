//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMFExamples.ComponentBasedSystems;
using NMFExamples.ComponentBasedSystems.Assembly;
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
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMFExamples.ComponentBasedSystems.Deployment
{
    
    
    public class Environment_MM06ContainersCollection : ObservableOppositeOrderedSet<IEnvironment_MM06, IContainer_MM06>
    {
        
        public Environment_MM06ContainersCollection(IEnvironment_MM06 parent) : 
                base(parent)
        {
        }
        
        private void OnItemParentChanged(object sender, ValueChangedEventArgs e)
        {
            if ((e.NewValue != this.Parent))
            {
                this.Remove(((IContainer_MM06)(sender)));
            }
        }
        
        protected override void SetOpposite(IContainer_MM06 item, IEnvironment_MM06 parent)
        {
            if ((parent != null))
            {
                item.ParentChanged += this.OnItemParentChanged;
                item.Environment = parent;
            }
            else
            {
                item.ParentChanged -= this.OnItemParentChanged;
                if ((item.Environment == this.Parent))
                {
                    item.Environment = parent;
                }
            }
        }
    }
}

