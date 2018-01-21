using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaitionsHearing.Data
{
    public class HearingRepo : IHearingRepo
    {
        private HearingDbContext _ctx;
        public HearingRepo(HearingDbContext dbctx)
        {
            _ctx = dbctx;
        }
        public int GetMember(string name)
        {
            return _ctx.Members.Where(c => c.Name == name).Select(s => s.Id).FirstOrDefault();
        }

        public Member SearchMember(string name)
        {
            return _ctx.Members.Where(c => c.Name == name).FirstOrDefault();
        }

        public bool MemberEligibility(int memberId)
        {
            bool isEligible = false;
            var eligibleMember = (from m in _ctx.Members
                                  join ms in _ctx.Memberships
                                  on m.Id equals ms.Member.Id
                                  join i in _ctx.InsurancePlans
                                  on ms.InsurancePlan.Id equals i.Id
                                  where m.Id == memberId
                                  select m).FirstOrDefault();


            if (eligibleMember.Gender == Gender.Male && eligibleMember.Dob <= DateTime.UtcNow.AddYears(-40) && eligibleMember.EnrollmentDate <= DateTime.UtcNow.AddMonths(-6))
            {
                isEligible = true;
            }

            if (eligibleMember.Gender == Gender.Female && eligibleMember.Dob <= DateTime.UtcNow.AddYears(-35) && eligibleMember.EnrollmentDate <= DateTime.UtcNow.AddMonths(-3))
            {
                isEligible = true;
            }


            return isEligible;
        }

        public bool MemberEligibilityByName(string name)
        {
            bool isEligible = false;
            var eligibleMember = (from m in _ctx.Members
                                  join ms in _ctx.Memberships
                                  on m.Id equals ms.Member.Id
                                  join i in _ctx.InsurancePlans
                                  on ms.InsurancePlan.Id equals i.Id
                                  where m.Name == name
                                  select m).FirstOrDefault();


            if (eligibleMember.Gender == Gender.Male && eligibleMember.Dob <= DateTime.UtcNow.AddYears(-40) && eligibleMember.EnrollmentDate <= DateTime.UtcNow.AddMonths(-6))
            {
                isEligible = true;
            }

            if (eligibleMember.Gender == Gender.Female && eligibleMember.Dob <= DateTime.UtcNow.AddYears(-35) && eligibleMember.EnrollmentDate <= DateTime.UtcNow.AddMonths(-3))
            {
                isEligible = true;
            }


            return isEligible;
        }
    }
}
