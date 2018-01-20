using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaitionsHearing.Data
{
    public class Member
    {
        public Member()
        {
            InsurancePlans = new List<InsurancePlan>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int InsurancePlanId { get; set; }
        public DateTime Dob { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public Gender Gender { get; set; }
        public virtual List<InsurancePlan> InsurancePlans { get; set; }
    }

    public enum Gender
    {
        Male=1,
        Female
    }
}
