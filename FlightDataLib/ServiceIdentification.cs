using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightDataLib
{
    public class ServiceIdentification
    {
        int serviceIdentification;

        public ServiceIdentification(List<string> content)
        {
            serviceIdentification = int.Parse(content[0], System.Globalization.NumberStyles.HexNumber);
        }
        public int getServiceIdentification() { return serviceIdentification; }
    }
}
