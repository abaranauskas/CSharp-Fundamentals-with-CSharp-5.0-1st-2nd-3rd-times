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
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }
        
       public float AverageGrade;
       public float LowestGrade;
       public float HighestGrade;

        public string GradeDescription
        {
            get
            {
                string result;
                switch (AvarageLetterGrade)
                {
                    case 'A':
                        result = "Exelent";
                        break;
                    case 'B':
                        result = "Good";
                        break;
                    case 'C':
                        result = "Average";
                        break;
                    case 'D':
                        result = "Bellow Average";
                        break;
                    case 'E':
                        result = "Bearly Passed";
                        break;
                    default:
                        result = "Failed";
                        break;
                }
                return result;

            }
            
        }

        public char AvarageLetterGrade {
            get
            {
                char result;            //char yra kintamojo tipas kuris saugo tik viena reik6me jis yra value kintamasis ne pointeris
                if(AverageGrade >= 90)
                {
                    result = 'A';       //char kintamojo reiksme rasosi i ' ' o strin i " "
                }
                else if (AverageGrade >= 80)
                {
                    result = 'B';
                }
                else if (AverageGrade >= 70)
                {
                    result = 'C';
                }
                else if (AverageGrade >= 60)
                {
                    result = 'D';
                }
                else if (AverageGrade >= 50)
                {
                    result = 'E';
                }
                else 
                {
                    result = 'F';
                }
                return result;
            }
        }
    }
}
