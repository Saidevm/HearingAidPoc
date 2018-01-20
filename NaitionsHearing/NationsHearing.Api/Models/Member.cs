using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NationsHearing.Api.Models
{
    public class Member
    {
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public DateTime DateOfBorth { get; set; }
        public DateTime MemberEnollmentDate { get; set; }
        public int Gender { get; set; }
        public virtual InsurancePlan InsurancePlanDetails { get; set; }
        public int InsurancePlanId { get; set; }
    }
}