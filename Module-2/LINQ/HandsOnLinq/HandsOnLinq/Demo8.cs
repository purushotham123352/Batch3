using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Demo8
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //deferred execution
            //var result = from i in numbers
            //             where i % 2 == 0
            //             select i;
            //numbers[1] = 21;
            //numbers[2] = 32;
            //foreach(var k in result)
            //{
            //    Console.WriteLine(k);
            //}
            List<int> result = (from i in numbers
                                where i % 2 == 0
                                select i).ToList();
            int[] no = (from i in numbers
                        where i % 2 == 0
                        select i).ToArray();
            int k1 = (from i in numbers
                     where i % 2 == 0
                     select i).First();
            numbers[1] = 21;
            foreach(var k in result)
            {
                Console.WriteLine(k);
            }
            Console.ReadKey();
        }
    }
}
