using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandsOnDemo.Repositories;
using HandsOnDemo.Model;
namespace HandsOnDemo
{
    class Client
    {
        public ProductRepository repository = new ProductRepository();
        public  void GetProducts()
        {
            foreach(var item in repository.GetProducts())
            {
                Console.WriteLine($"{item.ProductId} {item.ProductName} {item.Price} {item.Stock}");
            }
        }
        static void Main()
        {
            Client client = new Client();
            client.GetProducts();
        }
    }
}
