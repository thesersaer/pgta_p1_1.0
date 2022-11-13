using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightDataLib
{
    public class DataAgeItem
    {
        double age;
        string itemClass;
        public DataAgeItem(string octStr, string item)
        {
            age = int.Parse(octStr, System.Globalization.NumberStyles.HexNumber) * 0.1;
            itemClass = item;
        }
        public double getAge() { return age; }
        public string getItemClass() { return itemClass; }
    }
}
