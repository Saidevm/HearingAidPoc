using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaitionsHearing.Data
{
    public class Membership
    {
        public int Id { get; set; }
        public Member Member { get; set; }
        public InsurancePlan InsurancePlan { get; set; }
    }
}
