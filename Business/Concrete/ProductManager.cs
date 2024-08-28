using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public IDataResult<List<Product>> GetAll()
        {
           return new SuccessDataResult<List<Product>>(_productDal.GetAll(),true,Messages.ProductAdded);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Product> GetById(int productId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Product>> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        IResult IProductService.Add(Product product)
        {

            if (product.ProductName.Length < 2)
            {
                return new ErrorResult(Messages.ProductNameInvalid);
            }
            _productDal.Add(product);


            //  return new Result(true,"Ürün Eklendi"); bunun yerine

            return new SuccessResult();// Bu sayede Result class ına hem true bilgisi hem de message bilgisi gönderilebilir
        }

        // Buna constructor injection denir
        //IProductDal _productDal;

        //public ProductManager(IProductDal productDal)
        //{
        //    _productDal = productDal;
        //}
        //                                                  IDataResult öncesi kodlar
        //

        //public ProductManager(IProductDal productDal)
        //{
        //    _productDal = productDal;
        //}

        //public void Add(Product product)
        //{
        //    _productDal.Add(product);
        //}

        //public List<Product> GetAll()
        //{
        //    //Business kodları
        //    //Yetkisi var mı ?


        //    return _productDal.GetAll();
        //}

        //public List<Product> GetAllByCategoryId(int categoryId)
        //{
        //   return _productDal.GetAll(p=>p.CategoryId == categoryId);
        //}

        //public Product GetById(int productId)
        //{
        //    return _productDal.Get(p=>p.ProductId == productId);
        //}

        //public List<Product> GetByUnitPrice(decimal min, decimal max)
        //{
        //    return _productDal.GetAll(p=>p.UnitPrice >= min && p.UnitPrice<= max);
        //}

        //public List<Product> GetProductDetails()
        //{
        //    throw new NotImplementedException();
        //}


    }
}
