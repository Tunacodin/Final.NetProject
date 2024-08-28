using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        //  List<Product> GetAll(); eskiden sadece Product listesini döndürürken şimdi ise message true false bilgisiyle birlikte Product Listesini döndürür
        IDataResult<List<Product>> GetAll();

        //  List<Product>
        IDataResult<List<Product>> GetAllByCategoryId(int categoryId);

        //  List<Product>
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);

        //  List<Product>
        IDataResult<List<Product>> GetProductDetails();

        //  Product
        IDataResult<Product> GetById(int productId);

        // void Add(Product product) yerine IResult.. IResult hem işlemi yapar true false döndürür hem de message bilgsi verir 
        IResult Add(Product product);



    }
}
