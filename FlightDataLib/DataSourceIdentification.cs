using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightDataLib
{
    public class DataSourceIdentification
    {
        int sic;
        int sac;

        public DataSourceIdentification(List<string> content)
        {
            sac = int.Parse(content[0], System.Globalization.NumberStyles.HexNumber);
            sic = int.Parse(content[1], System.Globalization.NumberStyles.HexNumber);
        }
        public int getSic() { return sic; }
        public int getSac() { return sac; }
    }
}
