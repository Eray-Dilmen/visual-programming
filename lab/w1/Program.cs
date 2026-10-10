using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w1
{
    internal class Program
    {
        static void ornek1()
        {
            Console.WriteLine("Hello world");
            Console.WriteLine("visual #C");

            String x = "xx";
            String y = "yyyy";
            Console.WriteLine(x + y); // output: xxyyyy

            Console.ReadKey(); // kullanıcıdan bir karakter alana kadar bekler. Genelde kullanım amacı programın kapanmasını önlemek amaçlıdır.  

        }

        static void Main(string[] args)
        {
            ornek1(); 

        }
    }
}
