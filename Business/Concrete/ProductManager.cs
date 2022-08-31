using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.ınMemory;
using Entities.Concrete;
using Entities.DTOs;
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

        public IResult Add(Product product)
        {
                if(product.ProductName.Length<2)
            {   
                //magic string:Boşluklu string yazıları ileride sorun oluşturabilir.
                return new ErrorResult(Messages.ProductNameInvalid);
            }
             _productDal.Add(product);
            //return new Result(true,"Ürün eklendi");                                          //Result result =new Result();diyip
            return new SuccessResult(Messages.ProductAdded);                                          //result.Message vs de yazabiliriz tabiki ama yandaki gibi yapmamızın sebebi
                                                                                               //Kodu yazan kafasına göre değiştirmesin diye constructor ile set ederek
                                                                                               //standart hale getirelim diye böyle yapıyoruz.
        }

        public IDataResult<List<Product>> GetAll()
        {
            //İş kodları
            if (DateTime.Now.Hour == 14)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),Messages.ProductsListed);

        }

        public IDataResult<List<Product>>GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id));
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == productId));
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            if (DateTime.Now.Hour == 3)
            {
                return new ErrorDataResult<List<ProductDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
        }

     
    }
}
