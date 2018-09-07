using System;
using System.Collections.Generic;
using System.IO;

namespace Grades
{
    public class GradeBook : GradeTracker
    {
        //public GradeBook():this("No Name")
        //{

        //}

        public override void DoSomething()
        {
            
        }

        public GradeBook(string name="No nameeee")
        {
            _grades = new List<float>();
            _name = name;
            Console.WriteLine("GradeBook ctor");
        }

        public override void AddGrade(float grade)
        {
            if (grade <= 100 && grade > 0)
            {
               _grades.Add(grade);
            }
            
            
        }

        public override void WriteGrades(TextWriter textWriter)
        {
            textWriter.WriteLine("Grades: ");

            //foreach (float grade in _grades)
            //{
            //    textWriter.WriteLine(grade);
            //};

            //for (int i = 0; i < _grades.Count; i++)
            //{
            //    textWriter.WriteLine(_grades[i]+" is for");
            //}

            int y = 0;
            while (y<_grades.Count)
            {
                textWriter.WriteLine(_grades[y] + " is While");
                y++;
            }

            textWriter.WriteLine("**********");
        }

        public override GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            Console.WriteLine("Gradebook compute");

            float sum = 0f;
            foreach (float grade in _grades)
            {
                sum += grade;

                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);

                stats.BiggestGrade = Math.Max(grade, stats.BiggestGrade);
            }

            stats.average = sum / _grades.Count;        

            return stats;
        }





        protected List<float> _grades;  
         
    }
}
