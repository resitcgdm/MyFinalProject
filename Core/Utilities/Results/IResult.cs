using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{   
    //Temel voidler için başlangıç
    public interface IResult
    {
        bool Success { get; } //get sadece okunabilir anlamında.set yazmak için.
        string Message { get;}

    }
}
