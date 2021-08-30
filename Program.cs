using MinhaCDN_Challenge.Helper.Parser;
using MinhaCDN_Challenge.Helper.Transpiler;
using System;

namespace MinhaCDN_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var sourcepath = args[0];
            var destinationpath = args[1];

            Console.WriteLine("Starting Job");

            var mINHACDNParser = new MinhaCDNFileParser();
            var mINHACDNLogs = mINHACDNParser.GetLogs(sourcepath);

            var converter = new AgoraConverter();
            converter.ConvertMinhaCDN<Program>(mINHACDNLogs, destinationpath);

            Console.WriteLine("Job Finished");
        }
    }
}
