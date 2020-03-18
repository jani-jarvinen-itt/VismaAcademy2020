using System;

namespace Tietoturva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            char[] merkit = {'a','b','c'};
            Console.WriteLine("Taulukko alustettu.");

            Console.WriteLine("Merkki 1: "+merkit[0]);
            Console.WriteLine("Merkki 2: "+merkit[1]);
            Console.WriteLine("Merkki 3: "+merkit[2]);

            Console.WriteLine("Merkki 4: "+merkit[3]);
        }
    }
}
