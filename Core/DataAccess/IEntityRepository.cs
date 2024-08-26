using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess // Core katmanı diğer katmanları bağımlı değildir
{
    //T den kastımız veritabanı varlıklarıdır, Customer Category Product gibi

    //Generic Constrait-- T:class referans tiplere izin verir değer tiplere değil
    //Herhangi bir referans özelliğine sahip Tipler yazılmasın sadece Entityler yazılsın
    //IEntity olacak ya da IEntity implemente eden yani kullanan class (Customer, Product, Category vs) olabilir
    //Fakat implemente eden classlar içerisine <IEntity> girebiliyorum ve hatalı, o yüzden new() lenebilir olmasını da istiyorum
    public interface IEntityRepository<T> where T : class, IEntity,new()

        //Product, Order, Category, Customer vs işlemlerinin hepsini Generic Tip kullanarak yapabiliriz
    {

        // BUNLARA ELVEDA 
        //List<Product> GetAll();

        //void Add(Product product);

        //void Delete(Product product);

        //void Update(Product product);

        //List<Product> GetAllByCategory(int CategoryId);

        List<T> GetAll(Expression<Func<T,bool>> filter=null); // Tüm verileri getirir ya da filtrelemeyle getirir(Expression)

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);


    }

}
