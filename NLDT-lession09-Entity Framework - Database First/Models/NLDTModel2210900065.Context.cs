﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NLDT_lession09_Entity_Framework___Database_First.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NldtK22cnt3Lession07DbEntities : DbContext
    {
        public NldtK22cnt3Lession07DbEntities()
            : base("name=NldtK22cnt3Lession07DbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<NldtKetQua> NldtKetQua { get; set; }
        public virtual DbSet<NldtKhoa> NldtKhoa { get; set; }
        public virtual DbSet<NldtMonHoc> NldtMonHoc { get; set; }
        public virtual DbSet<NldtSinhVien> NldtSinhVien { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}