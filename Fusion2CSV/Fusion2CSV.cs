using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fusion2CSV
{
    public class Fusion2CSV
    {
        public void ResponseToFile(string response, string file)
        {
            var csvText = ResponseFormatter(response);
            WriteToCSV(csvText, file);
        }

        private string ResponseFormatter(string response)
        {
            var newResponse = response.Replace(@"\n", "\n");
            newResponse = newResponse.Replace(",", ", ");
            newResponse = newResponse.Replace("\"", "");

            return newResponse;
        }

        private void WriteToCSV(string response, string file)
        {
            System.IO.File.WriteAllText(file, response);
        }
    }
}
