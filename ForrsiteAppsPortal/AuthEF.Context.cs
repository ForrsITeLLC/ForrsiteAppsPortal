﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ForrsiteAppsPortal
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class app_authentication_devEntities : DbContext
    {
        public app_authentication_devEntities()
            : base("name=app_authentication_devEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AppRegistration> AppRegistrations { get; set; }
        public virtual DbSet<Authentication> Authentications { get; set; }
        public virtual DbSet<AppUserValidation> AppUserValidations { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AppType> AppTypes { get; set; }
        public virtual DbSet<UserDeviceRegistration> UserDeviceRegistrations { get; set; }
    }
}
