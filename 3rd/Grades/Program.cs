using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            IGradeTracker book = CreateGradeBook();

            book.AddGrade(95);
            book.AddGrade(93);
            book.AddGrade(99.9f);
            book.AddGrade(76.7f);
            book.AddGrade(76.7f);




            try
            {
                //string[] lines = File.ReadAllLines(@"C:\Users\aidas\OneDrive\Documents\Visual Studio 2015\Projects\C# Fundamentals with C# 5.0 3rd time\Grades\Grades\bin\Debug\grades.txt");
                //foreach (string line in lines)
                //{
                //    book.AddGrade(float.Parse(line));
                //}

                using (FileStream stream = File.Open("grades.txt", FileMode.Open))
                using (StreamReader reader = new StreamReader(stream))
                {


                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        book.AddGrade(float.Parse(line));
                        line = reader.ReadLine();
                    }
                }

            }
            catch (FileNotFoundException ex)
            {

                Console.WriteLine("Tokio failo neradome, todel programa baigiasi" + ex.Message);
                return;
            }
            //finally
            //{
            //    if (reader!=null)
            //    {
            //        reader.Close();
            //    }

            //    if (stream != null)
            //    {
            //        stream.Close();
            //    }
            //}

            book.DoSomething();
            book.WriteGrades(Console.Out);




            GradeStatistics stats = book.ComputeStatistics();

            book.NameChanged += OnNameChanged;
            book.NameChanged += OnNameChanged2;
            book.NameChanged += OnNameChanged;
            book.NameChanged += OnNameChanged;

            book.NameChanged -= OnNameChanged;

            try
            {
                //Console.WriteLine("iveskite varda");
                //book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine($"pagavaom exceptiona {ex.Message}");
            }


            WriteNames(book.Name);

            Console.WriteLine($"Vidurkis {stats.average}");
            Console.WriteLine($"Zemiausias {stats.LowestGrade}");
            Console.WriteLine($"Didziausias {stats.BiggestGrade}");
            Console.WriteLine($"Letter grades is {Char.ToUpper(stats.LetterGrade)} whick is {stats.Description.First().ToString().ToUpper() + stats.Description.Substring(1)}");

            book.Name = "Vanagas";

            //book.Name = Console.ReadLine();




        }

        private static GradeTracker CreateGradeBook()
        {
            GradeTracker book = new ThrowAwayGradeBook("Aidededelio");
            return book;
        }

        private static void OnNameChanged2(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("*********************"); ;
        }

        private static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Vardas pakeistas is {args.OldValue} i {args.NewValue}."); ;
        }

        private static void WriteNames(params string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
