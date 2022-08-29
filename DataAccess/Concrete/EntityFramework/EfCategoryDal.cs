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
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NortwindContext>, ICategoryDal
    {
        //IDisposable pattern implementation of c#

        //using yazmayıp direk icerideki
        //gibi yazsakda olur ama
        //context ler cok yer kapladıgı
        //icin garbage collector(çöp toplayıcı)
        //using yazılanları işi biter bitmez bellekten
        //silmek için alır çöpe atar.

    }





}
