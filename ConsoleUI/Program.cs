
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.Memory;

namespace ConsoleUI
{

    //SOLID -- Single Responsibility P. , Open/Closed P. , Liskov Subsitution P. , Interface Segregation P. , Dependency Inversion P.
    class Program
    {
        static void Main(string[] args)
        {
            //Veri deposu sağlanır memoryDal bizim ürettiğimi local bir veri kaynağı
            // MemoryProductDal memoryProductDal = new MemoryProductDal();
            // ProductManager productManager = new ProductManager(memoryProductDal);

            //Veri deposu sağlanır EntityCategoryDal dinamik bir veritabanı


            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach(var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }

            //ProductManager productManager = ProductTest();
            //foreach (var product in productManager.GetAllByCategoryId(5))
            //{
            //    Console.WriteLine("Category Id 5: " + product.ProductName);
            //}

            //foreach (var product in productManager.GetAllByCategoryId(2))
            //{
            //    Console.WriteLine(product.CategoryId);
            //}

           



        }

        //private static ProductManager ProductTest()
        //{
        //    EfProductDal efProductDal = new EfProductDal();
        //    ProductManager productManager = new ProductManager(efProductDal);

        //    foreach (var product in productManager.GetByUnitPrice(100, 200))
        //    {
        //        Console.WriteLine("Ürün fiyatı: " + product.UnitPrice + " Ürün Adı:" + product.ProductName);

        //    }

        //    return productManager;
        //}
    }
}