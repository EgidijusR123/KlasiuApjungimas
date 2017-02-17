using System;

namespace PasipraktikuotiKlases
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
    }
}
