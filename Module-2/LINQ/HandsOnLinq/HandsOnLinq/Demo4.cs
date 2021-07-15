using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Demo4
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var query = numbers.Single(n => n > 9);
            Console.WriteLine(query);
            query = numbers.SingleOrDefault(n => n > 9);
            Console.WriteLine(query);
        }
    }
}
