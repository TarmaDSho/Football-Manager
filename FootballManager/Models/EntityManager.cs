//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FootballManager.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EntityManager
    {
        public EntityManager()
        {
            this.Championship = new HashSet<Championship>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Championship> Championship { get; set; }
    }
}