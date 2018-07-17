namespace _1_TypyGeneryczne
{
    public class KolejkaKolowa
    {
        private double[] bufor;
        private int pocztekBufora;
        private int koniecBufora;

        public KolejkaKolowa() : this(pojemnosc: 5)
        {
        }

        public KolejkaKolowa(int pojemnosc)
        {
            bufor = new double[pojemnosc + 1];
            pocztekBufora = 0;
            koniecBufora = 0;
        }

        public void Zapisz(double wartosc)
        {
            bufor[koniecBufora] = wartosc;
            koniecBufora = (koniecBufora + 1) % bufor.Length;

            if (koniecBufora == pocztekBufora)
                pocztekBufora = (pocztekBufora + 1) % bufor.Length;
        }

        public double Czytaj()
        {
            var wynik = bufor[pocztekBufora];
            pocztekBufora = (pocztekBufora + 1) % bufor.Length;
            return wynik;
        }

        public int Pojemnosc
        {
            get
            {
                return bufor.Length;
            }
        }

        public bool JestPusty
        {
            get
            {
                return koniecBufora == pocztekBufora;
            }
        }

        public bool JestPelny
        {
            get
            {
                return (koniecBufora + 1) % bufor.Length == pocztekBufora;
            }
        }
    }
}
