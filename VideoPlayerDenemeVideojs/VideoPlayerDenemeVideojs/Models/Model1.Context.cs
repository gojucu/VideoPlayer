﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VideoPlayerDenemeVideojs.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AkademinyaEntities : DbContext
    {
        public AkademinyaEntities()
            : base("name=AkademinyaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Kurs> Kurs { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Uye> Uye { get; set; }
        public virtual DbSet<UyeKurs> UyeKurs { get; set; }
        public virtual DbSet<UyeVideo> UyeVideo { get; set; }
        public virtual DbSet<Video> Video { get; set; }
    }
}
