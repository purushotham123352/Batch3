using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Demo6
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int []n1 = numbers.Where(i => i % 2 == 0).ToArray();
            List<int> l1 = numbers.Where(i => i % 2 == 1).ToList();
        }
    }
}
