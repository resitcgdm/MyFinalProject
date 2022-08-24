using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{   
    //Bir classın default hali internaldir. Internal : bu classa sadece entites ulaşabilir demek.
    public class Product:IEntity //public : bu classa diğer katmanlarda ulaşabilsin demek.
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }  //short int'in bir küçüğü
        public decimal UnitPrice { get; set; }
    }
}
