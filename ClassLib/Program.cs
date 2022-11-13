using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            //uapCat21 testuapcat21 = new uapCat21();
            string path = "C:/Users/sersa/source/repos/pgta-p1/pgta-p1/Ficheros_asterix/201002-lebl-080001_smr.ast";
            //AsterixFile achPrueba = new AsterixFile();
            //achPrueba.setFilepath(path);
            //achPrueba.readFile();

            AsterixFile Asterix = new AsterixFile();
            Asterix.setFilepath(path);
            Asterix.readFile();
            List<Cat10> listCat10 = new List<Cat10>();
            listCat10 = Asterix.getListCat10SMR();
            Console.WriteLine(listCat10);
            Console.ReadKey();
        }
    }
}
