﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Golestane_Shohada.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GolestanShohadaEntities : DbContext
    {
        public GolestanShohadaEntities()
            : base("name=GolestanShohadaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bakhsh> Bakhshes { get; set; }
        public virtual DbSet<Mantaghe> Mantaghes { get; set; }
        public virtual DbSet<MatalebEzafe> MatalebEzafes { get; set; }
        public virtual DbSet<Mogheyat> Mogheyats { get; set; }
        public virtual DbSet<Niroo> Niroos { get; set; }
        public virtual DbSet<NirooYegan> NirooYegans { get; set; }
        public virtual DbSet<NoeMatlab> NoeMatlabs { get; set; }
        public virtual DbSet<NoeRabete> NoeRabetes { get; set; }
        public virtual DbSet<NoghteAsar> NoghteAsars { get; set; }
        public virtual DbSet<Ostan> Ostans { get; set; }
        public virtual DbSet<Raste> Rastes { get; set; }
        public virtual DbSet<Shahrestan> Shahrestans { get; set; }
        public virtual DbSet<Vahed> Vaheds { get; set; }
        public virtual DbSet<Vaziat> Vaziats { get; set; }
        public virtual DbSet<Yegan> Yegans { get; set; }
        public virtual DbSet<YeganVahed> YeganVaheds { get; set; }
        public virtual DbSet<AfzoodaneEtelaat> AfzoodaneEtelaats { get; set; }
        public virtual DbSet<Amaliat> Amaliats { get; set; }
        public virtual DbSet<Ashnayan> Ashnayans { get; set; }
        public virtual DbSet<NirooYeganVahedAmaliat> NirooYeganVahedAmaliats { get; set; }
        public virtual DbSet<Shahid> Shahids { get; set; }
        public virtual DbSet<ShahidAmaliat> ShahidAmaliats { get; set; }
        public virtual DbSet<ShahidRabete> ShahidRabetes { get; set; }
        public virtual DbSet<ViewAmaliat> ViewAmaliats { get; set; }
        public virtual DbSet<ViewNirooVahed> ViewNirooVaheds { get; set; }
        public virtual DbSet<ViewShahid> ViewShahids { get; set; }
        public virtual DbSet<ViewShahidAmaliat> ViewShahidAmaliats { get; set; }
    }
}
