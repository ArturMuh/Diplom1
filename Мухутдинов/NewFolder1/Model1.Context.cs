﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Мухутдинов.NewFolder1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Diplom_Мухутдинов1Entities1 : DbContext
    {
        public Diplom_Мухутдинов1Entities1()
            : base("name=Diplom_Мухутдинов1Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Avtory> Avtory { get; set; }
        public virtual DbSet<Biblioteka> Biblioteka { get; set; }
        public virtual DbSet<Izdatelstvo> Izdatelstvo { get; set; }
        public virtual DbSet<Knigi> Knigi { get; set; }
        public virtual DbSet<Postavshik> Postavshik { get; set; }
        public virtual DbSet<Razdeli> Razdeli { get; set; }
        public virtual DbSet<Sostav_zakaza> Sostav_zakaza { get; set; }
        public virtual DbSet<Spisanie> Spisanie { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Vid_izdanie> Vid_izdanie { get; set; }
        public virtual DbSet<Zakaz> Zakaz { get; set; }
    }
}
