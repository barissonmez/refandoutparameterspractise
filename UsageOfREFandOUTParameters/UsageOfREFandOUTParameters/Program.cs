using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsageOfREFandOUTParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            SampleRefTestMethod(ref i);
            Console.WriteLine(i);

            int y;
            SampleOutTestMethod(out y);
            Console.WriteLine(y);



            SampleRefOutTestMethod(out y, ref i);
            Console.WriteLine(i);
            Console.WriteLine(y);


            Console.ReadLine();



        }

        private static void SampleOutTestMethod(out int y)
        {
            y = 10;
        }

        private static void SampleRefTestMethod(ref int i)
        {
            i++;
        }

        private static void SampleRefOutTestMethod(out int y, ref int i)
        {
            i = i * 3;
            y = 20 * 5;
        }
    }
}
