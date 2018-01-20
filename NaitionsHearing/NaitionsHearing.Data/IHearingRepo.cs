using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaitionsHearing.Data
{
    public interface IHearingRepo
    {
        int GetMember(string name);
        Member SearchMember(string name);
    }
}
