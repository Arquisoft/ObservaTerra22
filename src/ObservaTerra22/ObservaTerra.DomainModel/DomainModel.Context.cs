﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ObservaTerra.DomainModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DomainModelContainer : DbContext
    {
        public DomainModelContainer()
            : base("name=DomainModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Area> Areas { get; set; }
        public DbSet<Indicator> Indicators { get; set; }
        public DbSet<Measure> Measures { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Observation> Observations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ITime> ITimes { get; set; }
        public DbSet<IComponent> IComponents { get; set; }
        public DbSet<Role> RoleSet { get; set; }
    }
}
