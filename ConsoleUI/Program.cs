// See https://aka.ms/new-console-template for more information

// Abstract:Soyut demek => Yani interfaceleri,abstract classı,BaseClassı buraya ekleriz
//Concrete:Somut,varlık demek => Yani asıl uygulamaları yönettiğimiz kontrol ettiğimiz methotları barındıran yer.
//Abstractlar ile uygulamalar arasındaki bağımlılıkları minimize eder.Referans tutucudurlar yani.


using Business.Concrete;
using Core.DataAccess.EntityFrameork;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.ınMemory;
using Entities.DTOs;

//SOLID
//Open Closed Pirinciple : İlerde yeni bir değişiklik gelirse mevcut kodlarına dokunamazsın.

ProductTest();
//IoC
//CategoryTest();

//DTO : Data Transformation Object

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());

    foreach (var product in productManager.GetProductDetails())
    {
        Console.WriteLine(" Ürün ismi :{0}  \nKategori Adı:{1} ", product.ProductName,product.CategoryName);
    }
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
        Console.WriteLine(" Category Id: {0}", category.CategoryId);
    }
}
