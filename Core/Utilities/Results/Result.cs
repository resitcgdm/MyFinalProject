using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
       

        public Result(bool success, string message):this(success)   //alttaki de çalışır, bu da çalışır.
                                                                    //this bu classı kasteder.
        {   
            Message = message;                              //sadece getter idi.Getter readonlydir.
                                                            //Readonly 'ler constructor ile set edilebilir.
        }
        public Result(bool success)             //overloading (aşırı yükleme) onuda karşılasın , bunu da karşılasın.
        {
                                        
            Success = success;                          
        }
        public bool Success { get; } //=> throw new NotImplementedException(); 

        public string Message { get; } //=> throw new NotImplementedException();
    }
}
