using MinhaCDN_Challenge.Business;
using MinhaCDN_Challenge.Business.Utils;
using MinhaCDN_Challenge.Models;
using System;
using System.Collections.Generic;
using static MinhaCDN_Challenge.Business.Utils.CommomUtilities;

namespace MinhaCDN_Challenge.Helper.Parser
{
    public class MinhaCDNFileParser
    {
        public List<MINHACDN> GetLogs(string sourceUrl)
        {
            var normalize = new Normalize();
            var sourcePath = normalize.ValidateURL(sourceUrl);

            var io = new FileHandler();
            var streamedFile = io.StreamFile(sourcePath.ToString());
            var document = io.ReadFile(streamedFile);

            var splitLog = new CommomUtilities();
            var lines = splitLog.ListLogLines(document);

            var logs = new List<MINHACDN>();
            foreach (var line in lines)
            {
                var values = splitLog.SplitColumnValues(line);
                MINHACDN log = new MINHACDN
                {
                    CacheStatus = values[2],
                    HTTPMethod = values[3],
                    ProtocolVersion = values[5],
                    ResponseSize = Int16.Parse(values[0]),
                    StatusCode = Int16.Parse(values[1]),
                    TimeTaken = Decimal.Parse(values[6]),
                    UriPath = values[4]
                };
                logs.Add(log);
            }
            return logs;
        }
    }
}
