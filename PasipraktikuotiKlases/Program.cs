using System;

namespace PasipraktikuotiKlases
{
    class Program
    {
        class Automoblis
        {
            public string AutomobilioMarke { get; private set; }
            public string AutomobilioModelis { get; private set; }
            public int AutomobilioGalia { get; private set; }
            public int AutomobilioPagaminimoMetai { get; private set; }
            public int AutomobilioRida { get; private set; }

            public Automoblis() 
            {
            }

            public Automoblis(string marke, string modelis, int galia, int metai, int rida)
            {
                AutomobilioMarke = marke;
                AutomobilioModelis = modelis;
                AutomobilioGalia = galia;
                AutomobilioPagaminimoMetai = metai;
                AutomobilioRida = rida;
            }

            public void IvedimasAutomobiliui()
            {
                Console.WriteLine("Iveskite automobilio marke");
                AutomobilioMarke = Console.ReadLine();
                Console.WriteLine("Iveskite automobilio modeli");
                AutomobilioModelis = Console.ReadLine();
                Console.WriteLine("Iveskite automobilio galia");
                AutomobilioGalia = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Iveskite automobilio metai");
                AutomobilioPagaminimoMetai = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Iveskite automobilio rida");
                AutomobilioRida = Convert.ToInt32(Console.ReadLine());
            }

           /* public void InformacijaAutomobiliui()
            {
                Console.WriteLine("Marke: " + AutomobilioMarke);
                Console.WriteLine("Modelis: " + AutomobilioModelis);
                Console.WriteLine("Galia: " + AutomobilioGalia);
                Console.WriteLine("Metai: " + AutomobilioPagaminimoMetai);
                Console.WriteLine("Rida: " + AutomobilioRida);
            }*/
        }
         class Zmogus 
         {
             public string ZmogausVardas { get; private set; }
             public int ZmogausAmzius { get; private set; }
             public bool ArZmogusTurejoAvariju { get; private set; }
             public bool ArZmogusTuriNuolaidu { get; private set; }

             public Zmogus() 
             {
             }

             public Zmogus(string vardas, int amzius, bool avarijos, bool nuolaidos)
             {
                ZmogausVardas = vardas;
                ZmogausAmzius = amzius;
                ArZmogusTurejoAvariju = avarijos;
                ArZmogusTuriNuolaidu = nuolaidos;
             }

             public void IvedimasZmogui()
             {
                 Console.WriteLine("Iveskite zmogaus varda");
                 ZmogausVardas = Console.ReadLine();
                 Console.WriteLine("Iveskite zmoguas amziu");
                 ZmogausAmzius = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Iveskite ar zmogus turejo avariju, jei taip true, jei ne false");
                 ArZmogusTurejoAvariju = Convert.ToBoolean(Console.ReadLine());
                 Console.WriteLine("Iveskite ar zmogus turi nuolaidu, jei taip true, jei ne false");
                 ArZmogusTuriNuolaidu = Convert.ToBoolean(Console.ReadLine());
             }

       /*      public void InformacijaZmogui()
             {
                 Console.WriteLine("Vardas: " + ZmogausVardas);
                 Console.WriteLine("Amzius: " + ZmogausAmzius);
                 Console.WriteLine("Ar turi avariju: " + ArZmogusTurejoAvariju);
                 Console.WriteLine("Ar turi nuolaidu: " + ArZmogusTuriNuolaidu);
             }*/
         }
         class DraudimoKompanijos
         {
             public string DraudimoPavadinimas { get; private set; }
            // public bool ArDraudziaPoAvarijos { get; private set; }
             public int DraudziamojoMinAmzius { get; private set; }
             public int DraudziamojoMaxAmzius { get; private set; }
             public bool ArTeikiamaNuolaida { get; private set; }
             public double DraudimoKaina {get; private set; }

             public DraudimoKompanijos()
             {
             }

             public DraudimoKompanijos(string pavadinimas,/* bool arDrausPoAvar,*/ int MinAmz,int MaxAmz, bool ArNuolaid, double kaina)
             {
                 DraudimoPavadinimas=pavadinimas;
               //  ArDraudziaPoAvarijos=arDrausPoAvar;
                 DraudziamojoMinAmzius=MinAmz;
                 DraudziamojoMaxAmzius=MaxAmz;
                 ArTeikiamaNuolaida=ArNuolaid;
                 DraudimoKaina=kaina;
             }

             public void IvedimasDraudimo()
             {
                 Console.WriteLine("Iveskite draudimo kompanijos pavadinima");
                 DraudimoPavadinimas = Console.ReadLine();
                // Console.WriteLine("Iveskite ar kompanija draus po avarijos");
             //    ArDraudziaPoAvarijos = Convert.ToBoolean(Console.ReadLine());
                 Console.WriteLine("Iveskite min draudimo amziu");
                 DraudziamojoMinAmzius = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Iveskite max draudimo amziu");
                 DraudziamojoMaxAmzius = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Iveskite ar kompanija teiks nuolaida nuolatiniam klientui");
                 ArTeikiamaNuolaida = Convert.ToBoolean(Console.ReadLine());
                 Console.WriteLine("Iveskite draudimo numatyta kaina");
                 DraudimoKaina = Convert.ToDouble(Console.ReadLine());
                 
             }

       /*      public void InformacijaDraudimui()
             {
                 Console.WriteLine("Imone: " + DraudimoPavadinimas);
             //    Console.WriteLine("Ar draus po avarijos: " + ArDraudziaPoAvarijos);
                 Console.WriteLine("Min draudziamojo amzius: " + DraudziamojoMinAmzius);
                 Console.WriteLine("Max draudziamojo amzius: " + DraudziamojoMaxAmzius);
                 Console.WriteLine("Ar bus taikomos nuolaidos: " + ArTeikiamaNuolaida);
                 Console.WriteLine("Kokia pradine draudimo kaina: " + DraudimoKaina);
             }*/
         }
        private void AutomobiliuIvedimas(Automoblis[] automobiliai, int kiekis)
            {
                for (int i = 0; i < kiekis; i++)
                {
                    Automoblis automob = new Automoblis();
                    automob.IvedimasAutomobiliui();
                //llllllllllll
                    automobiliai[i] = automob;
                }
            }

        private void ZmoniuIvedimas(Zmogus[] zmogus, int kiekis)
        {
            for (int i = 0; i < kiekis; i++)
            {
                Zmogus zmog = new Zmogus();
                zmog.IvedimasZmogui();
                zmogus[i] = zmog;
            }
        }

     /*   private void DraudimuIvedimas(DraudimoKompanijos[] draudimas, int kieis) //paverst i list
        {
            for (int i=0; i < kieis; i++)
            {
                DraudimoKompanijos draud = new DraudimoKompanijos();
                draud.IvedimasDraudimo();
                draudimas[i] = draud;
            }
        }*/
        
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
     
        private double Skaiciuokle(double kof1, double kof2)//bendra kof skaiciuokle
        {
            return kof1+kof2;
        }

        private double Parinkimas(Zmogus zmogus,DraudimoKompanijos draudimas,double koeficeintas)
        {
            if (zmogus.ZmogausAmzius < draudimas.DraudziamojoMinAmzius || zmogus.ZmogausAmzius > draudimas.DraudziamojoMaxAmzius)
            {
                Console.WriteLine("Kompanija nedraudzia");
                return 0.0;
            }
            else if (zmogus.ArZmogusTuriNuolaidu == draudimas.ArTeikiamaNuolaida && zmogus.ArZmogusTuriNuolaidu == true)
            {
                Console.WriteLine("Kompanija draus ir kaina bus {0}", (draudimas.DraudimoKaina * koeficeintas));
                return koeficeintas;
            }
            else return 0.0;
        }

        static void Main(string[] args)
        {
            Program programele = new Program();
            Console.WriteLine("Iveskite kiek bus variantu:");
            var Kiek = Convert.ToInt32(Console.ReadLine());
            Automoblis[] automobilis = new Automoblis[Kiek];
            Zmogus[] zmogus = new Zmogus[Kiek];
           // DraudimoKompanijos[] draudimasss = new DraudimoKompanijos[4];
            double[] koeficientas = new double[Kiek];
            //PADARYTI CIKLA AUTO IR ZMOGUS PO VIENA
            for 
            programele.AutomobiliuIvedimas(automobilis, Kiek);
            programele.ZmoniuIvedimas(zmogus, Kiek);
            //  programele.DraudimuIvedimas(draudimasss, 1);
            DraudimoKompanijos[] Drauduuumas =
             {
                new DraudimoKompanijos("Ergo",18,65,true,200),
                new DraudimoKompanijos("PZU",25,50,false,150),
                new DraudimoKompanijos("Kompensa",21,50,false,170),
                new DraudimoKompanijos("Lietuvos draudimas",18,70,true,190)
            };
            for(int i = 0; i < Kiek; i++)
            {
                Console.WriteLine(  programele.AutomobilioKoeficientas(automobilis[i]));
                double kof1 = programele.AutomobilioKoeficientas(automobilis[i]);
                Console.WriteLine(  programele.ZmogausKoeficientas(zmogus[i]) );
                double kof2 = programele.AutomobilioKoeficientas(automobilis[i]);
                koeficientas[i] = programele.Skaiciuokle(kof1, kof2);
                Console.WriteLine(koeficientas[i]);
                programele.Parinkimas(zmogus[i], Drauduuumas[3], koeficientas[i]);
            }

            Console.ReadKey();
        }
    }
}
