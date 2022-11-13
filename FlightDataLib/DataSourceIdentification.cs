using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace FlightDataLib
{
    public class DataSourceIdentification
    {
        int sic;
        int sac;

        public DataSourceIdentification(DataField dataField)
        {
            sac = int.Parse(dataField.getDataField()[0], System.Globalization.NumberStyles.HexNumber);
            sic = int.Parse(dataField.getDataField()[1], System.Globalization.NumberStyles.HexNumber);
        }
        public int getSic() { return sic; }
        public int getSac() { return sac; }
    }
}
