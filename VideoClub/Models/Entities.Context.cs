﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VideoClub.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VideoClubEntities : DbContext
    {
        public VideoClubEntities()
            : base("name=VideoClubEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Copies> Copies { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Distributors> Distributors { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Movies> Movies { get; set; }
        public virtual DbSet<Rentals> Rentals { get; set; }
    }
}
