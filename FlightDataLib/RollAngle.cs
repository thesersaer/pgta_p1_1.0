using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace FlightDataLib
{
    public class RollAngle
    {
        double rollAngle; //cw wrt rear view

        public RollAngle(DataField dataField)
        {
            List<string> content = dataField.getDataField();
            rollAngle = Utilities.compl2(int.Parse(content[0] + content[1], System.Globalization.NumberStyles.HexNumber)) * 0.01;
        }
        public double getRollAngle() { return rollAngle; }
    }
}
