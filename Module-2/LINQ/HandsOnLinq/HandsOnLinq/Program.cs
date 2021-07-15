using System;
using System.Linq;

namespace HandsOnLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] no = { 12, 23, 34, 4, 56, 54, 32, 22, 21, 78, 89 };
            //fetch even values
            var result = from i in no
                         where i % 2 == 0
                         select i;
            //var result = no.Where(i => i % 2 == 0);
            //fetch odd values >20
            //var result1 = from k in no
            //              where k % 2 != 0 && k > 20
            //              select k;
            int[] res = (from i in no
                         where i % 2 == 0
                         select i).ToArray(); //immediate execution
            no[0] = 11;
           
            foreach (int k in res)
                Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
