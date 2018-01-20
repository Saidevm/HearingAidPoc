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
        [Route(@"Members/Search/{name}")]
        [HttpGet]
        public int SearchByMember(string name)
        {
           return hrepo.GetMember(name);
        }

    }
}
