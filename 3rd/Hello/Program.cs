using System;


namespace Hello
{
    class Program
    {
        static void Main(string[] argumentai)
        {
            Console.WriteLine("Koks tavo vardas");
            string name = Console.ReadLine();
            Console.WriteLine("Kiek valanadu miegojai praeita nakti");
            int valandos = Int32.Parse(Console.ReadLine());

            if (valandos > 8)
            {
                Console.WriteLine("{0} o tu turetum but gerai pailsejes jei istikruju miegojai {1}", name, valandos);
            } else
            {
                Console.WriteLine($"{name} o tu xujovai miegijai, jei miegojai {valandos}");
            }
            

        }
    }
}
