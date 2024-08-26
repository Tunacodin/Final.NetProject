
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.Memory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Veri deposu sağlanır memoryDal bizim ürettiğimi local bir veri kaynağı
            // MemoryProductDal memoryProductDal = new MemoryProductDal();
            // ProductManager productManager = new ProductManager(memoryProductDal);

            //Veri deposu sağlanır EntityCategoryDal dinamik bir veritabanı

           
            EfProductDal efProductDal = new EfProductDal();
            ProductManager productManager = new ProductManager(efProductDal);

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.UnitPrice);
            }




        
        }
    }
}