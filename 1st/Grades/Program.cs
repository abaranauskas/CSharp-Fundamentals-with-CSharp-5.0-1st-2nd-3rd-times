using System;
using System.Collections.Generic;
using System.IO;
using System.Speech.Synthesis;


namespace Grades
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //GradeBook book = new GradeBook("Aido knygos");

            //GradeBook book = new ThrowAwayGradeBook("Aido knyga"); //cia jau OOP
            IGradeTracker book = CraeteGradeBook();


            //book.AddGrade(91f);
            //book.AddGrade(89.1f);
            //book.AddGrade(75f);


            //FileStream stream = null;
            //StreamReader reader = null;

            try
            {
                using (FileStream stream = File.Open("grades.txt", FileMode.Open)) //sitaip galima panaudoti uzsing kuris turi magic closing ir tada nereikia finally
                using (StreamReader reader = new StreamReader(stream)) //tokiu atveju net ir pagaunant exceptiona bus uzdaromas filas cia lower level dirbant su filu
                {
                    string line = reader.ReadLine();

                    //string[] lines = File.ReadAllLines("grades.txt"); //read all line nevisada tinka nes gali but filas per didelis ir poan
                    //foreach (string line in lines)

                    while (line != null)
                    {
                        book.AddGrade(float.Parse(line));
                        line = reader.ReadLine();
                    }
                    //reader.Close();  //butinai reikiauzdaryt bet cia negerai nes jei exceptionas pasitaikys tada numes koda kitur ir neuzdarys
                    //stream.Close();
                }

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not valid grade.txt");
                return;
            }
            catch (UnauthorizedAccessException ex)   //gali gaudyti kiek nori exceptionu
            {
                Console.WriteLine("you dont have access to grade.txt");
                return;
            }
            //finally
            //{
            //    if (reader != null)
            //    {
            //        reader.Close();  //cia vienas is budu kad viska uzdarytufinally kodas visada suveiks nesvarbu ar exceptionas ar kitka
            //    }

            //    if (stream != null)
            //    {
            //        stream.Close();  //bet tada reader ir stream deklaruoti outside try
            //    }
            // }

            //book.DoSomething();
            //book.WriteGrades(Console.Out);

            foreach(float grade in book)
            {
                Console.WriteLine(grade);
            }

            int j;
            do
            {
                try
                {
                    //Console.WriteLine("Please enter the name for the book");
                    //book.Name = Console.ReadLine();
                    j = 1;
                }
                catch (ArgumentException ex)  //ex jei nenaudojamas jo nebutina rasyti
                {
                    Console.WriteLine("Invalid name");
                    j = 2;
                }
            } while (j != 1);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);

            //Console.WriteLine(stats.AvarageLetterGrade);
            //Console.WriteLine(stats.GradeDescription);

            Console.WriteLine("Your grade is {0} {1}", stats.AvarageLetterGrade, stats.GradeDescription);



        }

        private static IGradeTracker CraeteGradeBook()
        {
            IGradeTracker book = new ThrowAwayGradeBook("Aido knyga");
            return book;
        }

    }
}
