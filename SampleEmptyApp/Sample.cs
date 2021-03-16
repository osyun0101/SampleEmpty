using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEmptyApp
{
    class Sample
    {
        //  コンストラクタ
        public Sample()
        {
            Console.WriteLine("コンストラクタ");
        }
        //  デストラクタ
        ~Sample()
        {
            Console.WriteLine("デストラクタ");
        }
    }
}
