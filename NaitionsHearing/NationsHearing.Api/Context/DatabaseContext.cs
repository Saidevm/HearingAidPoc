using NationsHearing.Api.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NationsHearing.Api.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DefaultConnection")
        { }

        public DbSet<Member> Members { get; set; }
        public DbSet<InsurancePlan> InsurancePlans { get; set; }
    }
}