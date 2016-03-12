using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace inForce.Models
{
    public class InForceDbContext : DbContext
    {
        public DbSet<Agent> Agents { get;set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Client> Clients {get;set; }

        public DbSet<inForce.Models.Salesforce.Contact> Contacts { get; set; }
        public DbSet<GlobalUser> GlobalUsers { get; set; }

        public InForceDbContext() : base("DefaultConnection")
        {

        }

    }
}