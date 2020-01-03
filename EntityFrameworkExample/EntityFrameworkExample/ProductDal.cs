using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (OrnekDBContext context = new OrnekDBContext())
            {
                return context.Products.ToList();
            }
        }
        public List<Product> GetByName(string key)
        {
            using (OrnekDBContext context = new OrnekDBContext())
            {
                return context.Products.Where(p=>p.Name.Contains(key)).ToList();
            }
        }
        public void Add(Product product)
        {
            using (OrnekDBContext context = new OrnekDBContext())
            {
                //context.Products.Add(product);
                var entity = context.Entry(product);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Update(Product product)
        {
            using (OrnekDBContext context = new OrnekDBContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(Product product)
        {
            using (OrnekDBContext context = new OrnekDBContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }

}
