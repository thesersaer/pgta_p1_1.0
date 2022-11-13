using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace FlightDataLib
{
    public class ServiceIdentification
    {
        int serviceIdentification;

        public ServiceIdentification(DataField dataField)
        {
            serviceIdentification = int.Parse(dataField.getDataField()[0], System.Globalization.NumberStyles.HexNumber);
        }
        public int getServiceIdentification() { return serviceIdentification; }
    }
}
