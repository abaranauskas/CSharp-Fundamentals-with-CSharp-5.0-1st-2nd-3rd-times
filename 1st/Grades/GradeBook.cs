using System;
using System.Collections;
using System.Collections.Generic; //is cia gauna "List" ir "add" kint cia kaip array
using System.IO;

namespace Grades
{
    public class GradeBook : GradeTracker
    {
        //public GradeBook() //konstruktorius
        //    :this("No name!")   // saukimas kontruktotiu is kito konstrukjei nera parametro taip nukreipiama i kita konstruktoriu priskirian no name
        //{
        //    //grades = new List<float>();  
        //}

        public GradeBook(string name = "Nu ka nera vardo!") //vietoj to kad naudoti 2 konstruktorius ir this galima nustatyti default value jei nieko neivedama 
        {
            Console.WriteLine("GradeBook ctor");
            Name = name;
            grades = new List<float>();
        }

        public override IEnumerator GetEnumerator()
        {
            return grades.GetEnumerator();
        }

        public override void DoSomething()
        {

        }





        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
        }

        public override GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("gradebook computestat");
            GradeStatistics stats = new GradeStatistics();

            float sum = 0f;

            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(stats.HighestGrade, grade);
                stats.LowestGrade = Math.Min(stats.LowestGrade, grade);
                sum += grade;    
            }

            stats.AverageGrade = sum / grades.Count; 


            return stats;
        }


        public override void WriteGrades(TextWriter textwriter)
        {
            textwriter.WriteLine("Grades:");
            //foreach (float grade in grades)
            //{
            //    textwriter.WriteLine(grade);
            //}

            //for (int i = 0; i < grades.Count; i++)
            //{
            //    int j = i;
            //    textwriter.WriteLine("{0} pazymys {1}", ++j, grades[i]);
            //}


            //int i = grades.Count - 1;
            //while (i >= 0)
            //{
            //    textwriter.WriteLine(grades[i]);
            //    i--;
            //}

            int i = 0;
            do
            {
                textwriter.WriteLine(grades[i]);
                i++;
            } while (i<grades.Count);


            textwriter.WriteLine("****************************");
        }


        protected List<float> grades; //cia kaip masyvas

         //delegate ir event skiresi sintaktiskai tik del event zodzio
    }
}
