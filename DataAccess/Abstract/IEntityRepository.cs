using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
        //Generic Constraint yapıyoruz aşağıda yani  T ancak referans tip olabilir.Değer tip olamaz int vs gibi.
        //IEntity olabilir veya ientity implemente eden bir nesne olabilir .
        //new(): newlenebilir olmalı.Interfaceler newlenemez yani IEntity olmasın istiyoruz sadece varlıklarımız olsun istiyoruz.


    public interface IEntityRepository<T>where T:class,IEntity,new()
    {                                                           //Kısacası bütün varlıklarımızın dal 'larını
                                                                //soyutlayarak Tek bir çatıda toplamış oluyoruz.
        List<T> GetAll(Expression<Func<T,bool>> filter=null);  //Bu yapı bizim ürünleri kategoriye göre listele,
                                                               //fiyata göre listeleme yapmamızı direk sağlıyor
                                                               //Extra her biri için yazmamıza gerek kalmıyor.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
       
    }
}
