﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _0908Datatable
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ALGCAMEntities1 : DbContext
    {
        public ALGCAMEntities1()
            : base("name=ALGCAMEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<SPM_Auto_Record_Log> SPM_Auto_Record_Log { get; set; }
        public virtual DbSet<SPM_Routing_TemplateInfo> SPM_Routing_TemplateInfo { get; set; }
    }
}
