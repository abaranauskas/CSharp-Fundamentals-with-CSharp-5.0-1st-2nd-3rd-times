using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pakartotinis
{
    class GradeBook
    {
        public GradeBook(string Name = "No Name")
        {
            _name = Name;
            grades = new List<float>();
        }

        public void AddGrades(float grade)
        {
            if(grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }            
        }

        

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            
            float sum = 0f;
            foreach(float grade in grades)
            {
                sum += grade;
                stats.BiggestGrade = Math.Max(grade, stats.BiggestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
            }

            stats.AverageGrade = sum / grades.Count;
            


            return stats;
        }

        public void WriteGrades(TextWriter textWriter)
        {
            textWriter.WriteLine("Grades:");

            foreach (float grade in grades)
            {
                textWriter.WriteLine(grade);
            };

            //for (int i = 0; i < grades.Count; i++)
            //{

            //    textWriter.WriteLine("from for Loop " + grades[i]);
            //}


            int i = grades.Count-1;
            while (i>=0)
            {
                textWriter.WriteLine("from WHILE Loop " + grades[i]);
                i--;
            }

            i = 0;
            do
            {
                textWriter.WriteLine("from DO WHILE Loop " + grades[i]);
                i++;

            } while (i<grades.Count);


            textWriter.WriteLine("*****************");


        }

        private string _name; 

        public string Name
        {
            get { return _name.ToUpper(); }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name canot be null or  empty!");
                }
                NameDelegateArgs args = new NameDelegateArgs();
                args.OldValue = _name;
                args.NewValue = value;
                if (args.OldValue != value )
                {
                    
                    _name = value;
                    if (NameChanged != null)
                    {
                        

                        NameChanged(this, args);
                    }
                }
                
            }
        }

        public NameChangedDelegate NameChanged;

        private List<float> grades;
    }
}
