using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEmptyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            s = null;
            GC.Collect();
        }
    }
}
