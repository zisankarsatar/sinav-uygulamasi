﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuizApp.Models.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class quizAppEntities : DbContext
    {
        public quizAppEntities()
            : base("name=quizAppEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<q_cevap> q_cevap { get; set; }
        public virtual DbSet<q_kategori> q_kategori { get; set; }
        public virtual DbSet<q_kullanici> q_kullanici { get; set; }
        public virtual DbSet<q_soru> q_soru { get; set; }
        public virtual DbSet<q_sinavSonuc> q_sinavSonuc { get; set; }
    }
}
