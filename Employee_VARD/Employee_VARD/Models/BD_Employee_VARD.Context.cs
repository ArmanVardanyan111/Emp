﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Employee_VARD.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BD_Employee_VARDEntities : DbContext
    {

        public static BD_Employee_VARDEntities context_;

        public static BD_Employee_VARDEntities GetContext()
        {
            if (context_ == null)
            {
                context_ = new BD_Employee_VARDEntities();
            }
            
            return context_;
        }

        public BD_Employee_VARDEntities()
            : base("name=BD_Employee_VARDEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}