using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightDataLib
{
    class Program
    {
        static void Main(string[] args)
        {
            const string getTypeArg = "FlightDataLib.ACASResolutionAdvisoryReport, FlightDataLib";
            var createInsArg = Type.GetType(getTypeArg);
            List<string> content = new List<string>();
            var emptyDataField = Activator.CreateInstance(createInsArg, content);

        }
    }
}
