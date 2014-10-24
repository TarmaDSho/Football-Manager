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
    
    public partial class Match
    {
        public Match()
        {
            this.MatchGoals = new HashSet<MatchGoals>();
        }
    
        public int ID { get; set; }
        public int JourneyID { get; set; }
        public System.DateTime Date { get; set; }
        public System.DateTime KickoffTime { get; set; }
        public int VisitorTeamID { get; set; }
        public int GuestTeamID { get; set; }
    
        public virtual Team Team { get; set; }
        public virtual Team Team1 { get; set; }
        public virtual ICollection<MatchGoals> MatchGoals { get; set; }
    }
}