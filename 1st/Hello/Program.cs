using System;


namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("kiek miegojai?");
            int hoursOfSleep = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello, " + name);

            if(hoursOfSleep < 8)
            {
                Console.WriteLine("turetum but pavarges");
            }
            else
            {
                Console.WriteLine("Pailsejai gerai");
            }

        }
    }
}
