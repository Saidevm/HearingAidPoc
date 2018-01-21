using NaitionsHearing.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NationsHearing.Api.Controllers
{
    public class MemberController : ApiController
    {
        private IHearingRepo hrepo;
        public MemberController(IHearingRepo repo)
        {
            hrepo = repo;
        }

        [Route(@"Members/Id/{name}")]
        [HttpGet]
        public int GetId(string name)
        {
           return hrepo.GetMember(name);
        }

        [Route(@"Members/{name}")]
        [HttpGet]
        public Member Get(string name)
        {
            return hrepo.SearchMember(name);
        }

        [Route(@"Members/Eligibility/{name}")]
        [HttpGet]
        public bool IsEligible(string name)
        {
            return hrepo.MemberEligibilityByName(name);
        }
    }
}
