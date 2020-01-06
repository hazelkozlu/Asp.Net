using Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (NortwindContext context = new NortwindContext())
            {
                return context.Products.ToList();
            }
        }
        public Product Get(int id)
        {
            using (NortwindContext context = new NortwindContext())
            {
                return context.Products.SingleOrDefault(p => p.ProductID == id);
            }
        }
        public void Add(Product product)
        {
            using (NortwindContext context = new NortwindContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
        public void Update(Product product)
        {
            using (NortwindContext context = new NortwindContext())
            {
                //context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (NortwindContext context = new NortwindContext())
            {
                // context.Products.Add(product);
                context.SaveChanges();
            }
        }
    }
}

