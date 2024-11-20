namespace _5M13conFaktoryzacjaLiczby
{
    /*
     * Faktoryzacja liczby
     * wczytaj liczne naturalną n i wypisz wszystkie dzielniki
     * 
     * przukład:
     * 60 = 2*2*3*5
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("podaj liczbę: ");
            int n = int.Parse(Console.ReadLine());
            int dzielnik = 2;
            while(n > 1)
            {
                while(n % dzielnik == 0)
                {
                    Console.WriteLine(dzielnik);
                    n = n / dzielnik;
                }
                dzielnik++;
            }
        }
    }
}
