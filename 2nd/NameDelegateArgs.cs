using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pakartotinis
{
    public class NameDelegateArgs: EventArgs
    {
        public string OldValue { get; set; }
        public string NewValue { get; set; }
    }
}
