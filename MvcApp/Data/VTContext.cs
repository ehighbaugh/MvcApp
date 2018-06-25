using MvcApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MvcApp.Data
{
    public class VTContext : DbContext
    {
        public VTContext() : base("VTContext")
        { }

        public DbSet<Event> Event { get; set; }
        public DbSet<Organization> Organization { get; set; }
        public DbSet<Volunteer> Volunteer { get; set; }
        public DbSet<EventVolunteer> EventVolunteers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}