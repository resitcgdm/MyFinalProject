using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.ınMemory;
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
                
       IProductDal _productDal;         //ProductManager new lendiğinde bana bi IProductDal referansı ver demiş oluyoruz.
                                        //Şuan bu inmemory de olabilir entityframework de olabilir(veri erişim alternatifleri)

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
           //İş kodları
           return _productDal.GetAll();
           
        }

        public List<Product> GetAllByCategoryId(int id)
        {
           return _productDal.GetAll(p=>p.CategoryId==id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }
    }
}
