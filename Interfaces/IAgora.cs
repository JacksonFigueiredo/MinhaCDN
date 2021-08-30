using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaCDN_Challenge.Interfaces
{
    public interface IAgora : IBase
    {
        DateTime Date { get; set; }
        string Provider { get; }
        int TimeTaken { get; set; }
    }
}
