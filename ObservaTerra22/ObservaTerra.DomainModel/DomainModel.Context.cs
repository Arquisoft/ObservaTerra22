﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
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
    
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<Indicator> Indicators { get; set; }
        public virtual DbSet<Measure> Measures { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<Observation> Observations { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ITime> ITimes { get; set; }
        public virtual DbSet<Role> RoleSet { get; set; }
        public virtual DbSet<IComponent> IComponents { get; set; }
        public virtual DbSet<Pair> PairSet { get; set; }
    }
}
