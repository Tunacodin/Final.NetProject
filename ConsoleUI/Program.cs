
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Memory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Veri deposu sağlanır
            MemoryProductDal memoryProductDal = new MemoryProductDal();
            //Veri deposunu mağaza müdürü kullanır
            ProductManager productManager = new ProductManager(memoryProductDal);

            foreach(var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }

        }
    }
}