using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult //IDataResult<T> ne döndürürsek onu ver product mı,category mi vs (generic yapı)
    {
        T Data { get; }
    }
}
