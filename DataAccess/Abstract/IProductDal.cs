using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //Product veritabanı işlemleri
    public interface IProductDal : IEntityRepository<Product>
    {

        //Entities katmanındaki Product, Category entitylerine erişim sağladık
        //List<Product> GetAll();

        //void Add(Product product);

        //void Delete(Product product);

        //void Update(Product product);

        //List<Product> GetAllByCategory(int CategoryId);

        //Yukarıdaki kodlara gerek kalmadı IEntityRepository oluşturduk fakat IProductDal için öznel işlemler burada yapılabilir
        


    }
    }
