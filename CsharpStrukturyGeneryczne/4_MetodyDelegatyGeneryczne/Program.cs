using System;

namespace _4_MetodyDelegatyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {          
            var kolejka = new KolejkaKolowa<double>(pojemnosc:3);
            kolejka.elementUsuniety += Kolejka_elementUsuniety;


            WprowadzanieDanych(kolejka);
            kolejka.Drukuj(d => Console.WriteLine(d));            
            PrzetwarzanieDanych(kolejka);
        }

        private static void Kolejka_elementUsuniety(object sender, ElementUsunietyEventArgs<double> e)
        {
            Console.WriteLine("Kolejka jest pełna. Element usunięty to : {0} Nowy element to {1}", e.ElementUsuniety, e.ElementNowy);
        }

        private static void PrzetwarzanieDanych(IKolejka<double> kolejka)
        {
            var suma = 0.0;
            Console.WriteLine("W naszej kolejce jest :");

            while (!kolejka.JestPusty)
            {
                suma += kolejka.Czytaj();
            }
            Console.WriteLine(suma);
        }

        private static void WprowadzanieDanych(IKolejka<double> kolejka)
        {
            while (true)
            {
                var wartosc = 0.0;
                var wartoscWejsciowa = Console.ReadLine();

                if (double.TryParse(wartoscWejsciowa, out wartosc))
                {
                    kolejka.Zapisz(wartosc);
                    continue;
                }
                break;
            }
        }
    }
}
