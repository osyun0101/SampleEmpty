using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace SampleEmptyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] a = new int[7];
            for (int i = 0; i<a.Length; i++)
            {
                Random r = new Random();
                a[i] = r.Next(1, 10);
                Console.Write("a["+i+"]="+a[i]);
            }

        }

        /* public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        */
    }
}
