﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PnPAutomationUI
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PnPTestAutomationEntities : DbContext
    {
        public PnPTestAutomationEntities()
            : base("name=PnPTestAutomationEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<FileTrackingBaselineSet> FileTrackingBaselineSets { get; set; }
        public virtual DbSet<FileTrackingSet> FileTrackingSets { get; set; }
        public virtual DbSet<TestAuthenticationSet> TestAuthenticationSets { get; set; }
        public virtual DbSet<TestConfigurationPropertySet> TestConfigurationPropertySets { get; set; }
        public virtual DbSet<TestConfigurationSet> TestConfigurationSets { get; set; }
        public virtual DbSet<TestResultMessageSet> TestResultMessageSets { get; set; }
        public virtual DbSet<TestResultSet> TestResultSets { get; set; }
        public virtual DbSet<TestRunSet> TestRunSets { get; set; }
        public virtual DbSet<UsersSet> UsersSets { get; set; }
    }
}
