using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewMyProje.Entities;

namespace NewMyProje
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                return context.Products.ToList();
            }
        }
        public List<Product> GetByCategoryID(int categoryId)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                return context.Products.Where(p => p.CategoryID == categoryId).ToList();
            }
        }
        public List<Product> GetByProductName(string name)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                if (string.IsNullOrEmpty(name))
                {
                    return context.Products.ToList();
                   
                }
                else
                {
                    return context.Products.Where(p => p.ProductName.Contains(name)).ToList();
                }

            }
        }

        public List<Category> GetCategory()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                return context.Categories.ToList();

            }
        }

    }
}
