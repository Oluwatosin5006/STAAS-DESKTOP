//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace STAAS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class STAAS_dbEntities1 : DbContext
    {
        public STAAS_dbEntities1()
            : base("name=STAAS_dbEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin_User> Admin_User { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<Client_License> Client_License { get; set; }
        public virtual DbSet<Customization> Customizations { get; set; }
        public virtual DbSet<DB_Configuration> DB_Configuration { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Finger_Definition> Finger_Definition { get; set; }
        public virtual DbSet<Fingerprint> Fingerprints { get; set; }
        public virtual DbSet<Holiday> Holidays { get; set; }
        public virtual DbSet<License_Definition> License_Definition { get; set; }
        public virtual DbSet<Movement> Movements { get; set; }
        public virtual DbSet<Movement_Reason> Movement_Reason { get; set; }
        public virtual DbSet<Register> Registers { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<User_group> User_group { get; set; }
        public virtual DbSet<User_Picture> User_Picture { get; set; }
        public virtual DbSet<User_Type> User_Type { get; set; }
        public virtual DbSet<Voice_Prompt> Voice_Prompt { get; set; }
    }
}
