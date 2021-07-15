using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Demo2
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var query = numbers.First();
            Console.WriteLine("The first element in the sequence");
            query = numbers.First(i => i>10);
            Console.WriteLine(query);
            query = numbers.Last();
            query = numbers.Last(i => i % 2 != 0);
            Console.WriteLine("The last element in the sequence");
            Console.WriteLine(query);
            Console.WriteLine("The first even element in the sequence");
            query = numbers.First(n => n % 2 == 0);
            Console.WriteLine(query);
            Console.WriteLine("The last even element in the sequence");
            query = numbers.Last(n => n % 2 == 0);
            Console.WriteLine(query);
        }
    }
}
