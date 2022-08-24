// See https://aka.ms/new-console-template for more information

// Abstract:Soyut demek => Yani interfaceleri,abstract classı,BaseClassı buraya ekleriz
//Concrete:Somut,varlık demek => Yani asıl uygulamaları yönettiğimiz kontrol ettiğimiz methotları barındıran yer.
//Abstractlar ile uygulamalar arasındaki bağımlılıkları minimize eder.Referans tutucudurlar yani.


using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.ınMemory;

//SOLID
//Open Closed Pirinciple : İlerde yeni bir değişiklik gelirse mevcut kodlarına dokunamazsın.
ProductManager productManager = new ProductManager(new EfProductDal());

foreach (var product in productManager.GetByUnitPrice(50,100))  
{
    Console.WriteLine("Ürün Adı: {0}----Idsi:{1}",product.ProductName,product.UnitPrice);
}