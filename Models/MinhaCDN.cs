using MinhaCDN_Challenge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaCDN_Challenge.Models
{
    public class MINHACDN : IMINHACDN
    {
        public MINHACDN()
        {
        }
        public string CacheStatus { get; set; }
        public string HTTPMethod { get; set; }
        public string ProtocolVersion { get; set; }
        public int ResponseSize { get; set; }
        public int StatusCode { get; set; }
        public decimal TimeTaken { get; set; }
        public string UriPath { get; set; }
    }
}
