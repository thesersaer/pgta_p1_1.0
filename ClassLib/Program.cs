using System;
using System.Collections.Generic;
using System.IO;
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
            uapCat21 testuapcat21 = new uapCat21();
            var relPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName+ "\\testfiles\\201002-lebl-080001_adsb.ast";
            //string path = "C:/Users/sersa/Desktop/ejemplos_PGTA/Ficheros_asterix/201002-lebl-080001_adsb.ast";
            //string path = "C:/Users/gerar/OneDrive/Escriptori/Uni/201002-lebl-080001_adsb.ast";
            AsterixFile achPrueba = new AsterixFile();
            achPrueba.setFilepath(relPath);
            achPrueba.readFile();
            var listCat21 = achPrueba.getListCat21();

            //AsterixFile Asterix = new AsterixFile();
            //Asterix.setFilepath(path);
            //Asterix.readFile();
            //List<Cat10> listCat10 = new List<Cat10>();
            //listCat10 = Asterix.getListCat10SMR();
            //Console.WriteLine(listCat10);
            Console.ReadKey();
        }
    }
}
