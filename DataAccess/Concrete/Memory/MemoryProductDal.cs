using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Memory
{
    public class MemoryProductDal : IProductDal
    {
        //metodların dışında bir değişkeni _var şeklinde tanımlıyoruz
        List<Product> _products;

        public MemoryProductDal()
        {
            _products = new List<Product>() {
            new Product{ProductId=1, CategoryId=1, ProductName="TV", UnitPrice=20, UnitsInStock=100},
            new Product{ProductId=2, CategoryId=2, ProductName="Çamaşır Makinesi", UnitPrice=200, UnitsInStock=120}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete;
            //LINQ
            productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);

            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int CategoryId)
        {
           return  _products.Where(p=>p.CategoryId == CategoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate=_products.SingleOrDefault(_ => _.ProductId == product.ProductId);

            productToUpdate.ProductId= product.ProductId;
            productToUpdate.CategoryId= product.CategoryId;
            productToUpdate.ProductName= product.ProductName;
            productToUpdate.UnitPrice= product.UnitPrice;
            productToUpdate.UnitsInStock= product.UnitsInStock;


        }
    }
}
