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
            Person2 p = new Person2();
            //  名前と年齢を設定
            p.SetAgeAndName("山田太郎", 26);
            //  年齢の変更
            p.Age = 32;
            //  名前の変更（できない）
            //  p.Name = 36;
            //  名前と年齢の表示
            Console.WriteLine("名前：{0}　年齢:{1}", p.Name, p.Age);
            Console.Write("neko");
            int i;
            i = 23;
            Console.WriteLine(i);
        }
    }
}
