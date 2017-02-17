using System;
using System.Collections.Generic;

namespace PasipraktikuotiKlases
{
    class Program
    {
        private void InformacijosIvedimas(Automoblis[] automobiliai,Zmogus[] zmogus, int kiekis)
            {
                for (int i = 0; i < kiekis; i++)
                {
                    Automoblis automob = new Automoblis();
                    Zmogus zmog = new Zmogus();
                    automob.IvedimasAutomobiliui();
                    zmog.IvedimasZmogui();
                    automobiliai[i] = automob;
                    zmogus[i] = zmog;
            }
        }

       private double AutomobilioKoeficientas(Automoblis automobilis)
       {
            double koef = 0.0;
            const int dabartis= 2017;
            var senumas = 0;
            var RidaPerMetus = 0;
            senumas = dabartis - automobilis.AutomobilioPagaminimoMetai;
            if (senumas <= 0)
            { RidaPerMetus = 1000; }
            else { RidaPerMetus = automobilis.AutomobilioRida / senumas; }
            koef = ((double)senumas) / 4.5; 
            koef = ((double)automobilis.AutomobilioGalia / 50) * koef; 
            koef = ((double)RidaPerMetus / 4000) * koef;
            return koef;
        }

        private double ZmogausKoeficientas(Zmogus zmogus)
        {
            double koef = 0.0;
            if (zmogus.ArZmogusTurejoAvariju == true)
            {
                koef = 1.5;
            }
            else { koef = 0.7; }
            if (zmogus.ArZmogusTuriNuolaidu == true)
            {
                koef = koef * 0.8;
            }
            else { koef = koef * 1.2; }
            if (zmogus.ZmogausAmzius > 65)
            {
                koef = koef * 2;
            }
            else if (zmogus.ZmogausAmzius >= 18 && zmogus.ZmogausAmzius < 65)
            {
                koef = 40 / (double)zmogus.ZmogausAmzius * koef;
            }else { koef = 0.0; }
            return koef;
        }
     
        private double Skaiciuokle(double kof1, double kof2)
        {
            if (kof1 == 0 || kof2 == 0)
            {
                return 0.0;
            }
            return Math.Round((kof1 + kof2),1);
        }
        private void Isvedimas(Automoblis automobilis, Zmogus zmogus)
        {
            var ZmogInfo = zmogus.ZmogausVardas + " " + zmogus.ZmogausAmzius;
            var AutoInfo = automobilis.AutomobilioMarke + " " + automobilis.AutomobilioModelis;
            Console.WriteLine(ZmogInfo+" m., vairuojantis "+AutoInfo+" gali draustis:");
        }
        private void Parinkimas(Automoblis automobilis, Zmogus zmogus,List<DraudimoKompanijos> draudimai,double koeficeintas)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Isvedimas(automobilis, zmogus);
            foreach (var draudimas in draudimai)
            {
                if (zmogus.ZmogausAmzius < draudimas.DraudziamojoMinAmzius || zmogus.ZmogausAmzius > draudimas.DraudziamojoMaxAmzius)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0} nedraudzia!",draudimas.DraudimoPavadinimas);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (zmogus.ArZmogusTuriNuolaidu == draudimas.ArTeikiamaNuolaida && zmogus.ArZmogusTuriNuolaidu == true)
                {
                    Console.WriteLine("{1} draus ir kaina bus {0} EUR.", (draudimas.DraudimoKaina * koeficeintas), draudimas.DraudimoPavadinimas);
                }
                else
                {
                    Console.WriteLine("{1} draus ir kaina bus {0} EUR.", (draudimas.DraudimoKaina * koeficeintas), draudimas.DraudimoPavadinimas);
                }
            }
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            Program programele = new Program();
            Console.WriteLine("Iveskite kiek bus variantu:");
            var Kiek = Convert.ToInt32(Console.ReadLine());
            Automoblis[] automobilis = new Automoblis[Kiek];
            Zmogus[] zmogus = new Zmogus[Kiek];
            double[] koeficientas = new double[Kiek];
            programele.InformacijosIvedimas(automobilis, zmogus, Kiek);

            List<DraudimoKompanijos> Drauduuumas = new List<DraudimoKompanijos>();
            Drauduuumas.Add(new DraudimoKompanijos("Ergo", 18, 65, true, 200));
            Drauduuumas.Add(new DraudimoKompanijos("PZU", 25, 50, false, 150));
            Drauduuumas.Add(new DraudimoKompanijos("Kompensa", 21, 50, false, 170));
            Drauduuumas.Add(new DraudimoKompanijos("Lietuvos draudimas", 18, 70, true, 190));
            
            for(int i = 0; i < Kiek; i++)
            {
                double kof1 = programele.AutomobilioKoeficientas(automobilis[i]);
                double kof2 = programele.ZmogausKoeficientas(zmogus[i]);
                koeficientas[i] = programele.Skaiciuokle(kof1, kof2);
                programele.Parinkimas(automobilis[i], zmogus[i], Drauduuumas, koeficientas[i]);
            }
            Console.ReadKey();
        }
    }
}
