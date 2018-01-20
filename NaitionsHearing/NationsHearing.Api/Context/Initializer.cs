using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using NationsHearing.Api.Models;

namespace NationsHearing.Api.Context
{
    public class Initializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            base.Seed(context);

            //var InsurancePlan1 = new List<InsurancePlan> { new InsurancePlan { InsuancePlanName = "TestPlan1", InsurancePlanID = 1000 } };
            //var InsurancePlan2 = new List<InsurancePlan> { new InsurancePlan { InsuancePlanName = "TestPlan2", InsurancePlanID = 1000 } };
            //var InsurancePlan3 = new List<InsurancePlan> { new InsurancePlan { InsuancePlanName = "TestPlan3", InsurancePlanID = 1000 } };

            //var Member1 = new Member { DateOfBorth = DateTime.Now.AddYears(-50), Gender = (int)Gender.Male, InsurancePlanDetails = InsurancePlan1, MemberEnollmentDate = DateTime.Now, MemberID = 1, MemberName = "TestName1" };
            //var Member2 = new Member { DateOfBorth = DateTime.Now.AddYears(-50), Gender = (int)Gender.Female, InsurancePlanDetails = InsurancePlan1, MemberEnollmentDate = DateTime.Now, MemberID = 2, MemberName = "TestName2" };

            //context.Members.Add(Member1);
            //context.Members.Add(Member2);
            //context.SaveChanges();
        }
    }
}