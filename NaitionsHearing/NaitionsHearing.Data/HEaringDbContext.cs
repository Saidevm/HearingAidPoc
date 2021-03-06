﻿using NaitionsHearing.Data.Mapper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaitionsHearing.Data
{
    public class HearingDbContext : DbContext
    {
        public HearingDbContext() : base("name=constring")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<HearingDbContext, HearingContextMigrationConfiguration>());
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<InsurancePlan> InsurancePlans { get; set; }
        public DbSet<Membership> Memberships { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MemberMapper());
            modelBuilder.Configurations.Add(new InsurancePlanMapper());
            modelBuilder.Configurations.Add(new MembershipMapper());
        }
    }

    public class HearingContextMigrationConfiguration : DbMigrationsConfiguration<HearingDbContext>
    {
        public HearingContextMigrationConfiguration()
        {
            this.AutomaticMigrationDataLossAllowed = true;
            this.AutomaticMigrationsEnabled = true;
        }

#if DEBUG
        protected override void Seed(HearingDbContext context)
        {
            //base.Seed(context);
            new HearingDataSeeder(context).Seed();
        }
#endif
    }

    public class HearingDataSeeder
    {
        private HearingDbContext _ctx;
        public HearingDataSeeder(HearingDbContext ctx)
        {
            _ctx = ctx;
        }

        public void Seed()
        {
            if (_ctx.Members.Any())
            {
                return;
            }

            var inp = new InsurancePlan
            {
                Name = "Jeevan Suravi"
            };

            var linp = new InsurancePlan();
            //linp.Add(inp);

            var mem1 = new Member
            {
                Name = "Test Male Member1",
                Dob = DateTime.UtcNow.AddDays(-365 * 50),
                Gender = Gender.Male,
                //InsurancePlans = linp,
                EnrollmentDate = DateTime.UtcNow.AddDays(-365)
            };

            var mem2 = new Member
            {
                Name = "Test Female Member1",
                Dob = DateTime.UtcNow.AddDays(-365 * 50),
                Gender = Gender.Female,
                //InsurancePlans = linp,
                EnrollmentDate = DateTime.UtcNow.AddDays(-365)
            };

            var mship = new Membership
            {
                InsurancePlan = inp,
                Member = mem1
            };

            var mship1 = new Membership
            {
                InsurancePlan = inp,
                Member = mem2
            };

            _ctx.Members.Add(mem1);
            _ctx.Members.Add(mem2);
            _ctx.InsurancePlans.Add(inp);
            _ctx.Memberships.Add(mship1);
            _ctx.Memberships.Add(mship);
            _ctx.SaveChanges();

          

            //_ctx.Members.Add(mem1);
            //_ctx.Members.Add(mem2);
            //_ctx.InsurancePlans.Add(linp);
            //_ctx.SaveChanges();

        }
    }



}
