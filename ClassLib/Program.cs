﻿using System;
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
            uapCat21 testuapcat21 = new uapCat21();
            string path = "C:/Users/sersa/Desktop/ejemplos_PGTA/Ficheros_asterix/201002-lebl-080001_adsb.ast";
            //string path = "C:/Users/gerar/OneDrive/Escriptori/Uni/201002-lebl-080001_adsb.ast";
            AsterixFile achPrueba = new AsterixFile();
            achPrueba.setFilepath(path);
            achPrueba.readFile();
            var listCat21 = achPrueba.getListCat21();
            foreach (var iiCat21 in listCat21)
            {
                iiCat21.decodeDataFields();
            }

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
