using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Akademija_Sitecore_Lipeikaite_Vytaute_1_uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Įveskite tekstą (įvedimo užbaigimas klavišu Enter):");
            string tekstas = Console.ReadLine();


            if (tekstas != "")
            {
                int kiekis = DaugiausiaiIsEilesPasikartojanciuRaidziu(tekstas);
                Console.WriteLine("Daugiausiai iš eilės pasikartojančių raidžių kiekis: {0} ", kiekis);
            }
            else
            {
                Console.WriteLine("Neįvedėte teksto...");
            }
        }

        // grazina daugiausiai is eiles pasikartojanciu raidziu skaiciu
        static int DaugiausiaiIsEilesPasikartojanciuRaidziu(string tekstas)
        {
            int kiekis = 1; // daugiausiai pasikartojanciu raidziu is eiles kiekis
            int pap_kiekis = 0; // papildomas kiekis skaiciavimams
            string pirma_raide = ""; // pirmoji teksto raide

            while (tekstas.Length > 0)
            {
                pirma_raide = tekstas.Substring(0, 1);
                tekstas = tekstas.Remove(0, 1);

                pap_kiekis++;
                if (pap_kiekis > kiekis)
                    kiekis = pap_kiekis;

                if (tekstas.Length != 0)
                    if (pirma_raide != tekstas.Substring(0, 1))
                        pap_kiekis = 0;
            }

            return kiekis;
        }
    }
}
