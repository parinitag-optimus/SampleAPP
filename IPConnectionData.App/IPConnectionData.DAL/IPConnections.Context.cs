﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IPConnectionData.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IPConnectionDBEntities : DbContext
    {
        public IPConnectionDBEntities()
            : base("name=IPConnectionDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<IPConnectionsTable> IPConnectionsTables { get; set; }
        public virtual DbSet<JacquesTagTable> JacquesTagTables { get; set; }
        public virtual DbSet<Alarm> Alarms { get; set; }
        public virtual DbSet<AlarmsTagsTable> AlarmsTagsTables { get; set; }
    }
}
