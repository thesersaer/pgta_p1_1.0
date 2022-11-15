using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightDataLib
{
    public class ServiceManagement
    {
        double reportPeriod;
        // MAX reportPeriod == 127.5 indicates report period of 127.5 s OR ABOVE

        public ServiceManagement(List<string> content)
        {
            reportPeriod = int.Parse(content[0], System.Globalization.NumberStyles.HexNumber) * 0.5;
        }
        public double getReportPeriod() { return reportPeriod; }
    }
}
