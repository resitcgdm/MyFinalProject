using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {   //constant:sabit demek
        //statik yapınca newlenmeye gerek kalmaz.Tek yerde kullanılacaklar.
        //Normalde değişkenlerin ilk harfi küçük olur fakat public oldukları için PascalCase türünde yazılır.
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem bakımda";
        public static string ProductsListed="Ürünler listelendi";
    }
}
