using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace FlightDataLib
{
    public class GeometricHeight
    {
        double geometricHeight;

        public GeometricHeight(DataField dataField)
        {
            List<string> content = dataField.getDataField();
            this.geometricHeight = Utilities.compl2(int.Parse(content[0] + content[1], System.Globalization.NumberStyles.HexNumber)) * 6.25;
        }
        public double getGeometricHeight() { return geometricHeight; }
    }
}
