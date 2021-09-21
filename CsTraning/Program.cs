using CsTraning.Problem;
using System;

namespace CsTraning
{
    class Program
    {
        static void Main(string[] args)
        {
            var aaa = new Problem6();
            aaa.Problem6_4(2);
            aaa.Problem6_6(3);

            Console.WriteLine(1001 + " " + aaa.Problem6_7(1001));

            for (int i = 1; i <= 1000; i++)
			{
                Console.WriteLine(i + " " + aaa.Problem6_7(i));
			}

            Console.WriteLine("Hello World!");

            var tes = new Problem2();
        }
    }
}
