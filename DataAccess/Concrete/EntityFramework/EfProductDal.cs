using Core.DataAccess.EntityFrameork;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NortwindContext>, IProductDal
    {   //ORM:Object Relational Mapping--Linq destekli çalışır.
        //ORM:Veri tabanındaki tabloyu classmış gibi davranır ve kodlar arasında bağ kurup ,veri tabanındaki işleri yapar.

      
    }
}
