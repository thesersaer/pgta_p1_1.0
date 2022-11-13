using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightDataLib
{
    public class Utilities
    {
        public static int compl2(int value)
        {
            if ((value & 0x80) != 0) { return (~(value) - 0x1) * -1; }
            else return value;
        }
    }
}
