﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FMDBEntities : DbContext
    {
        public FMDBEntities()
            : base("name=FMDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Championship> Championship { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<EntityManager> EntityManager { get; set; }
        public virtual DbSet<Journey> Journey { get; set; }
        public virtual DbSet<Match> Match { get; set; }
        public virtual DbSet<MatchGoals> MatchGoals { get; set; }
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<Season> Season { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<TeamPoints> TeamPoints { get; set; }
    }
}
