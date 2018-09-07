using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.IO;

namespace Pakartotinis
{
    class Program
    {
        static void Main()
        {
            GradeBook book = new GradeBook("roko pazymiuknyga");

            //book.AddGrades(99f);
            //book.AddGrades(89.5f);
            //book.AddGrades(69.1f);
            //book.AddGrades(75f);
            //book.AddGrades(44.5f);
            //book.AddGrades(29.4f);

            try
            {
                string[] lines = File.ReadAllLines("rades.txt");

                foreach(string line in lines)
                {
                    book.AddGrades(float.Parse(line));
                }
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("file is not located!");
                return;
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("No access!");
            }

            book.WriteGrades(Console.Out);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.LowestGrade);
            Console.WriteLine(stats.BiggestGrade);
            Console.WriteLine("your grade is {0} which is {1} ",stats.LetterGrade,stats.GradeDescription);

            book.Name = "labas";
            WriteNames(book.Name);

            book.NameChanged += OnNameChange;

            bool x;
            do {
              
                try
                {
                    Console.WriteLine("Enter the book nsme");
                    book.Name = Console.ReadLine();
                    x = false;
               
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Invalid name!");
                    x = true;
                }
            } while (x);





            //int number = 45;
            //WriteBytes(number);
            //WriteBytes(stats.AverageGrade);

        }

        private static void OnNameChange(object sender, NameDelegateArgs args)
        {
            Console.WriteLine("Name change from {0} to {1}", args.OldValue, args.NewValue); ;
        }

        private static void WriteNames(string name)
        {
             Console.WriteLine(name);
        }

        private static void WriteBytes(float value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            WriteBytes(bytes);
        }        

        private static void WriteBytes(int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            WriteBytes(bytes);
        }


        private static void WriteBytes(byte[] bytes)
        {
            foreach (byte bite in bytes)
            {
                Console.WriteLine("{0:X}", bite);
            }
        }
    }
}
