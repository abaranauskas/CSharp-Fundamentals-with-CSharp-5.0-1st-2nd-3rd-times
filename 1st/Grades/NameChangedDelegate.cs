using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    //public delegate void NameChangedDelegate(string oldValue, string newValue); //cia kai delagate

    public delegate void NameChangedDelegate(
        object sender, NameChangedEventArgs args);  //cia kai event

}
