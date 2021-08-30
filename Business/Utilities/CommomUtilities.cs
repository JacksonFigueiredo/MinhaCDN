using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaCDN_Challenge.Business.Utils
{
    public class CommomUtilities
    {

        public List<string> SplitColumnValues(string line)
        {
            var values = line.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
            var fields = new List<string>();
            foreach (var value in values)
            {
                fields.Add(value);
            }
            return fields;
        }

        public List<string> ListLogLines(string file)
        {
            var logLines = new List<string>();
            var normalize = new Normalize();
            file = normalize.GetNewFormat(file);
            string[] lines = file.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                logLines.Add(line);
            }
            return logLines;
        }


        public class Normalize
        {
            public string GetNewFormat(string file)
            {
                return file.Replace("\"", "").Replace(" ", "|");
            }

            public Uri ValidateURL(string uri)
            {
                try
                {
                    return new Uri(uri);
                }
                catch (ArgumentNullException)
                {
                    throw;
                }
                catch (UriFormatException)
                {
                    throw;
                }
            }
        }

        public class Version
        {
            public decimal GetAssemblyVersion<T>(decimal appVersion)
            {
                try
                {
                    var version = typeof(T).Assembly.GetName().Version;
                    var stringVersion = $"{version.Major}.{version.Minor}";
                    return Decimal.Parse(stringVersion);
                }
                catch (ArgumentException)
                {
                    throw;
                }
                catch (FormatException)
                {
                    throw;
                }
                catch (OverflowException)
                {
                    throw;
                }
            }
        }
    }
}
