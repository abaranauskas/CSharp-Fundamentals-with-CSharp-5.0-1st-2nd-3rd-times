using System;

namespace Pakartotinis
{
    internal class GradeStatistics
    {
        public GradeStatistics()
        {
            BiggestGrade = float.MinValue;
            LowestGrade = float.MaxValue;
        }
        public float AverageGrade;
        public float LowestGrade;// = float.MaxValue;
        public float BiggestGrade;// = float.MinValue;

        public char LetterGrade
        {
            get
            {
                char result;
                if(AverageGrade>= 90)
                {
                    result = 'A';
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
                else
                {
                    result = 'F';
                }
                return result;
            }
        }

        public string GradeDescription
        {
            get
            {
                string result;
                switch (LetterGrade)
                {
                    case 'A':
                        result = "Excellent!";
                        break;
                    case 'B':
                        result = "Above average!";
                        break;
                    case 'C':
                        result = "Average!";
                        break;
                    case 'D':
                        result = "Bellow average!";
                        break;
                    default:
                        result = "You suck!";
                        break;
                }
                return result;
            }
        }
    }
}