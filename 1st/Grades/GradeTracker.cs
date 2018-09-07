using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public interface IGradeTracker : IEnumerable
    {
       void AddGrade(float grade);
       GradeStatistics ComputeStatistics();
       void WriteGrades(TextWriter textwriter);
        string Name { get; set; }
        event NameChangedDelegate NameChanged;
        void DoSomething();
        

    }

    public abstract class GradeTracker : IGradeTracker
    {
        public abstract void AddGrade(float grade);
        public abstract GradeStatistics ComputeStatistics();
        public abstract void WriteGrades(TextWriter textwriter);

        public abstract IEnumerator GetEnumerator();

        public abstract void DoSomething();

        public string Name
        {
            get
            {
                return _name.ToUpper();
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("NAME Negali but tuscia eilute arba null");
                }

                //if (!String.IsNullOrEmpty(value)) { //cia kai tikrinam ar ivedama reiksme ne tuscia

                if (_name != value)
                {   //cia tikrinam ar pasikeite reiksme
                    string oldValue = _name;
                    _name = value;

                    if (NameChanged != null)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs(); //cia kai eventas
                        args.OldValue = oldValue;
                        args.NewValue = value;

                        NameChanged(this, args); //this yra pats objektas t.y. GradeBook

                        //NameChanged(oldValue, value);  //cia kai tik delegate
                    }

                }
            }
        }

        public event NameChangedDelegate NameChanged;

        private string _name;
    }
}
