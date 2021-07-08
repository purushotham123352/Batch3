using HandsOnDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDemo.Repositories
{
    class ProductRepository : IProductRepository
    {
        private List<Product> products = new List<Product>();
        public void Add(Product product)
        {
            products.Add(product);
        }

        public Product GetProduct(int id)
        {
           foreach(var item in products)
            {
                if(item.ProductId==id)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
