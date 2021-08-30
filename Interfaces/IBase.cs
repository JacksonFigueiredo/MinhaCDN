using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaCDN_Challenge.Interfaces
{
    public interface IBase
    {
        string CacheStatus { get; set; }
        string HTTPMethod { get; set; }
        string ProtocolVersion { get; set; }
        int ResponseSize { get; set; }
        int StatusCode { get; set; }
        string UriPath { get; set; }
    }
}
