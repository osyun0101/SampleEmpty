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
            Random r = new Random();
            List<int> n = new List<int>();
            List<int> n2 = new List<int>();
            while (true)
            {
                int i = r.Next(0, 11);
                if (i % 2 == 0)
                {
                    n2.Add(i);
                }
                else
                {
                    n.Add(i);
                }
                Console.WriteLine("0～10の値を出力:{0}", i);
                if (i == 0)
                {
                    Console.Write("偶数:");
                    int index = 1;
                    foreach(int s in n2)
                    {
                        if (index == n2.Count)
                        {
                            Console.WriteLine(s);
                        }
                        else
                        {
                            Console.Write(s);
                        }
                        
                    }
                    break;
                }
            }
        }
    }
}
