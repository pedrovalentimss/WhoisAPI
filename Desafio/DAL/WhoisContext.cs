using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Desafio.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Desafio.DAL
{
    public class WhoisContext : DbContext
    {
        public WhoisContext() : base("WhoisContext")
        {
        }

        public DbSet<Whois> WhoisDb { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}