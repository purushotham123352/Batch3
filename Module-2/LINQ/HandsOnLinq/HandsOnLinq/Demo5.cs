using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Demo5
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var query = numbers.Where(i => i > 5).ElementAt(2);
            Console.WriteLine(query);
           query = numbers.ElementAtOrDefault(90);
            Console.WriteLine(query);
        }
    }
}
