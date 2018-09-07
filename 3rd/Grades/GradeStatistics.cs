using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            LowestGrade = float.MaxValue;
            BiggestGrade = float.MinValue;

        }




        public float average { get; set; }
        public float LowestGrade { get; set; }
        public float BiggestGrade { get; set; }
        public string Description
        {
            get
            {
                string result;
                switch (LetterGrade)
                {
                    case 'a':
                        result = "excellent";
                        break;
                    case 'b':
                        result = "above average";
                        break;
                    case 'c':
                        result = "average";
                        break;
                    case 'd':
                        result = "Bellow Average";
                        break;
                    default:
                        result = "failure";
                        break;
                }

                return result;
            }
        }

        public char LetterGrade
        {
            get
            {
                char pazymys;
                if (average >= 90)
                {
                    pazymys= 'a';
                }
                else if (average >= 80)
                {
                    pazymys = 'b';
                }
                else if (average >= 70)
                {
                    pazymys = 'c';
                }
                else if (average >= 60)
                {
                    pazymys = 'd';
                }
                else
                {
                    pazymys = 'f';
                }
                return pazymys;
            }
        }
    }
}
