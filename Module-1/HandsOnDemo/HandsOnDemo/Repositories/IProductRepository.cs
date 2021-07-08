using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandsOnDemo.Model;
namespace HandsOnDemo.Repositories
{
    interface IProductRepository
    {
        List<Product> GetProducts();
        Product GetProduct(int id);
        void Add(Product product);
    }
}
