using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class DataField
    {
        int frn;
        string dataFieldFspec;
        List<string> dataList = new List<string>();

        public DataField(int frn, List<string> contentArray)
        {
            this.frn = frn;
            dataList = contentArray;
        }
        public DataField(int frn, string fspec, List<string> contentArray)
        {
            this.frn = frn;
            dataList = contentArray;
            dataFieldFspec = fspec;
        }

        public int getFrn() { return frn; }
        public List<string> getDataField() { return dataList; }
        public string getDataFieldFspec() { return dataFieldFspec; }
    }
}
