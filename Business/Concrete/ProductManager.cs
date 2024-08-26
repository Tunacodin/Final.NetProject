using Business.Abstract;
using DataAccess.Abstract;
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

       // Buna constructor injection denir
        //IProductDal _productDal;

        //public ProductManager(IProductDal productDal)
        //{
        //    _productDal = productDal;
        //}

        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //Business kodları
            //Yetkisi var mı ?


            return _productDal.GetAll();
        }
    }
}
