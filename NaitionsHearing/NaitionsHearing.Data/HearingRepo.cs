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
    }
}
