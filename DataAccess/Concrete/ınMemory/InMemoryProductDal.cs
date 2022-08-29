using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.ınMemory
{
    public class InMemoryProductDal : IProductDal
    {
        
        List<Product> _products;
        public InMemoryProductDal()  //cotr ile contructor oluşturuyoruz.
        {   
            //Oracle,Sql Server,Postgres,MongoDb
            _products = new List<Product> { 
                new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
                new Product{ProductId=2,CategoryId=1,ProductName="Kamera",UnitPrice=500,UnitsInStock=3},
                new Product{ProductId=3,CategoryId=2,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2},
                new Product{ProductId=4,CategoryId=2,ProductName="Klavye",UnitPrice=150,UnitsInStock=65},
                new Product{ProductId=5,CategoryId=2,ProductName="Ekran Kartı",UnitPrice=85,UnitsInStock=1}

            };
        }
        public void Add(Product product)
        {
           _products.Add(product);
        }

        public void Delete(Product product)
        {
            //_products.Remove(product); bu kod normalde  siler ama burda silinmez.
            //Çünkü Listler referans tipli olduğu için referanslarını tutup öyle silebiliriz değer tipli olsalardı gerek kalmazdı.

            //LINQ :Language Integrated Query : Dile Gömülü Sorgulama => LINQ kullanırsak bu aşağıda yaptığımız sorgulamaya gerek kalmaz.


            //Product productToDelete=null;
            //foreach (var p in _products)
            //{
            //    if (product.ProductId==p.ProductId)
            //    {
            //        productToDelete = p;    
            //    }
            //    else
            //    {

            //    }
            //}
            Product productToDelete=_products.SingleOrDefault(p=>p.ProductId==product.ProductId); //LINQ p=> lambda işareti demek.Yukarı daki döngünün LINQ de ki hali...
                                                                                                  //SingleOrDefault sadece bir tane arar.
                                                                                                  
                                                                                                  // Genelde Id aramalarda kullanılır.
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

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryId == categoryId).ToList(); // where koşulu içeride ki şarta uyan bütün elemanları yeni bir liste yapar ve onu döndürür.
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {   
            //Gönderdiğim ürün id'sine sahip olan listedeki ürünü bul.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice; 
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.CategoryId=product.CategoryId;

        }
    }
}
