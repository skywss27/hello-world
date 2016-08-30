using EHOME.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace EHOME.DAL
{
    public class TeamContext: DbContext
    {
         public TeamContext() : base("TeamContext")
        {
        }
        
        public DbSet<TeamMember> Members { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}