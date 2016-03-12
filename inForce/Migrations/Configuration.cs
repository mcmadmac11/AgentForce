namespace inForce.Migrations
{
    using inForce;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<inForce.Models.InForceDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(inForce.Models.InForceDbContext context)
        {

            var _context = new InForceDbContext();
            var clients = new List<Client>
            {
                new Client {Name="Nick Wilson",PolicyNumber="AB001332" },
                new Client {Name="Brad McManus",PolicyNumber="AB0032234" },
            };
            clients.ForEach(c => context.Clients.Add(c));
            context.SaveChanges();
            var agents = new List<Agent>
            {
                new Agent {Name="Daniel McManus", ProducerNumber=1 },
            };
            agents.ForEach(a => context.Agents.Add(a));
            context.SaveChanges();
            base.Seed(context);



        }
    }
}
