using Microsoft.EntityFrameworkCore;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;


namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext> // Varlık olarak Product,Customer, Category, Context olarak yani Veri Kaynağı olarak NorthWindContext gibi 
        where TEntity : class,IEntity,new() // TEntity bir class olmalı ve newlenebilir olmalı, aynı zamanda bir entity olmalı
        where TContext : DbContext,new() // veritabanı erişimi new context yapılabilir olmalı
    {
        public void Add(IEntity entity)
        {
            //IDisposable pattern işlemi denir   using (TContext context = new TContext())
            //Using içerisindeki nesneler kullanım bitince bellekten(Garbage Collactor) atılır ve performans artar
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity); // Var olan entity ile eşleştirdi
                addedEntity.State = EntityState.Added; //Veritabanına ekle 
                context.SaveChanges();// Kaydet
            }

        }

        public void Delete(IEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity); // Var olan entity ile eşleştirdi
                deletedEntity.State = EntityState.Deleted; //Veritabanından silindi 
                context.SaveChanges();// Kaydet
            }

        }

        public IEntity Get(Expression<Func<IEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<IEntity>().SingleOrDefault(filter);
            }

        }

        public List<IEntity> GetAll(Expression<Func<IEntity, bool>> filter = null)// Expression<Func<Product, bool>> bu bir filtredir buraya istediğin verileri gönderebilirsin
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<IEntity>().ToList() : context.Set<IEntity>().Where(filter).ToList();
            }
        }

        public void Update(IEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity); // Var olan entity ile eşleştirdi
                updatedEntity.State = EntityState.Modified; //Veritabanından güncellendi 
                context.SaveChanges();// Kaydet
            }
        }
    }
}
