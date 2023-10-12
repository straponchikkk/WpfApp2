using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal class SingleTone
    {
        public static Entities DB { get;  } = new Entities();
    }
}
