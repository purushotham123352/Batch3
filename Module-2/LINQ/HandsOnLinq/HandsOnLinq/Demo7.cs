using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Demo7
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var r1 = from i in numbers
                     where i * i > 10
                     select i * i;
            var result = from i in numbers
                         let k = i * i
                         where k > 10
                         select k;
        }
    }
}
