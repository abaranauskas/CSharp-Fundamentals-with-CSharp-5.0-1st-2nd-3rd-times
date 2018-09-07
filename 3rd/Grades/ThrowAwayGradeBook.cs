using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class ThrowAwayGradeBook : GradeBook
    {
        public ThrowAwayGradeBook(string name) :
            base(name)
        {
            Console.WriteLine("ThrowAway ctor");
        }

        public override GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("ThrowAway compute");
            float lowets = float.MaxValue;
            foreach (float grade in _grades)
            {
                lowets = Math.Min(lowets, grade);
            }

            _grades.Remove(lowets);

            return base.ComputeStatistics();
        }
    }
}
