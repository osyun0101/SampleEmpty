using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEmptyApp
{
    //  電話インターフェース
    interface IPhone
    {
        //  指定した番号に電話をかける
        void Call(string number);
    }
}