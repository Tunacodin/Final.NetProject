using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
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

    //                                                           NuGet kullanmaya başlıyoruz
    //                                                             EntityFramework için

    //                                          ---EfEntityRepositoryBase<TEntity,TContext> kullanmadan önceki hali---


    //       public class EfProductDal : IProductDal
    //    {
    //        public void Add(Product entity)
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void Delete(Product entity)
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public Product Get(Expression<Func<Product, bool>> filter)
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void Update(Product entity)
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }
    //}
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthWindContext>,IProductDal
    {
       
    }

}
