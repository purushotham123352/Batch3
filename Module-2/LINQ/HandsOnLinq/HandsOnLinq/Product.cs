using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Product
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
    }
    class Test_Product
    {
        static void Main()
        {
            Product p = new Product();
            p.Pid = 12;
            p.Pname = "Speakers";
            p.Price = 4000;
                
            List<Product> products = new List<Product>()
            {
               
                new Product(){Pid=1,Pname="Mouse",Price=300,Stock=30},
                 new Product(){Pid=2,Pname="Keyboad",Price=300,Stock=30},
                new Product(){Pid=4,Pname="Pendrive",Price=500,Stock=30},
                         new Product(){Pid=3,Pname="Optical Mouse",Price=1300,Stock=30},
                            new Product(){Pid=5,Pname="Air buds",Price=3300,Stock=30},
                               new Product(){Pid=8,Pname="Air Pods",Price=10300,Stock=30},
                                  new Product(){Pid=9,Pname="Hear Phones",Price=800,Stock=30},
                            new Product(){Pid=10,Pname="Head Phones",Price=1300,Stock=30}
            };
            products.Add(p);
            products.Add(new Product() { Pid = 13, Pname = "Mouse", Price = 300, Stock = 30 });
            //fetch Product details of id 1
            // Product obj = products.SingleOrDefault(i => i.Pid == 1);
            var result = (from i in products
                          where i.Pid == 1
                          select i);
           Product obj = (from i in products
                   where i.Pid == 1
                   select i).SingleOrDefault();
            obj = products.First(i => i.Price > 500);
            obj = products.FirstOrDefault(i => i.Price > 50000);
            if (obj != null)
            {
                Console.WriteLine("{0} {1} {2} {3}", obj.Pid, obj.Pname, obj.Price, obj.Stock);
                Console.WriteLine($"{obj.Pid} {obj.Pname} {obj.Price} {obj.Stock}");
            }
            //get products of price >1000
            List<Product> list1 = products.Where(p => p.Price > 1000).ToList();
            foreach(var ob in list1)
                Console.WriteLine($"{ob.Pid} {ob.Pname} {ob.Price} {ob.Stock}");
            int c = products.Where(p => p.Price > 1000).Count();
        }
    }
}
