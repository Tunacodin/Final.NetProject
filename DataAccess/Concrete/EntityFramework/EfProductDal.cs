using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{

    //NuGet kullanmaya başlıyoruz
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            //IDisposable pattern
            //Using içerisindeki nesneler kullanım bitince bellekten(Garbage Collactor) atılır ve performans artar
            using (NorthWindContext context = new NorthWindContext())
            {
            var addedEntity = context.Entry(entity); // Var olan entity ile eşleştirdi
                addedEntity.State = EntityState.Added; //Veritabanına ekle 
                context.SaveChanges();// Kaydet
            }

        }

        public void Delete(Product entity)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                var deletedEntity = context.Entry(entity); // Var olan entity ile eşleştirdi
                deletedEntity.State = EntityState.Deleted; //Veritabanından silindi 
                context.SaveChanges();// Kaydet
            }

        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }

        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)// Expression<Func<Product, bool>> bu bir filtredir buraya istediğin verileri gönderebilirsin
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                return filter == null ? context.Set<Product>().ToList() :context.Set<Product>().Where(filter).ToList();
            }
        }

        public void Update(Product entity)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                var updatedEntity = context.Entry(entity); // Var olan entity ile eşleştirdi
                updatedEntity.State = EntityState.Modified; //Veritabanından güncellendi 
                context.SaveChanges();// Kaydet
            }
        }
    }
}
