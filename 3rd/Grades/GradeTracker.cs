using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public interface IGradeTracker
    {
        void AddGrade(float grade);
        GradeStatistics ComputeStatistics();
        void WriteGrades(TextWriter textWriter);
        string Name { get; set; }
        event NameChangedDelegate NameChanged;
        void DoSomething();
    }

    public abstract class GradeTracker: IGradeTracker
    {
        public abstract void AddGrade(float grade);
        public abstract GradeStatistics ComputeStatistics();
        public abstract void WriteGrades(TextWriter textWriter);
        public abstract void DoSomething();

        public string Name
        {
            get { return _name.ToUpper(); }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Vardas turi sudaryti bent viena simboli");
                }

                if (value != _name)
                {
                    //string oldName = _name;
                    //_name = value;
                    if (NameChanged != null)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.OldValue = _name;
                        args.NewValue = value;
                        _name = value;
                        NameChanged(this, args);
                    }

                }


            }
        }
        public event NameChangedDelegate NameChanged;
        protected string _name;
    }
}
