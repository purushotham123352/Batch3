using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Demo3
    {
        static void Main()
        {
            int[] numbers = { 1, 3, 5, 7, 9 };
            var query = numbers.FirstOrDefault(n => n % 2 == 0);
            Console.WriteLine("The first even element in the sequence");
            Console.WriteLine(query);
            Console.WriteLine("The last odd element in the sequence");
            query = numbers.LastOrDefault(n => n % 2 == 1);
            Console.WriteLine(query);
        }
    }
}
