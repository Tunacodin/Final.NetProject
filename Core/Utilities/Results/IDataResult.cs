using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{

    // IDataResult Product,Category vs entitylerini aynı zamanda Result bilgisini döndürür.
    public interface IDataResult<T> : IResult
    {
       T Data {get;  }


    }
}
