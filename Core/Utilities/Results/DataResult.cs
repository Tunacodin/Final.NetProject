using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        // this kullanmadık çünkü base kullanıyoruz

        // Zorunlu olarak constructor ile dönecek veri data
        // Diğer success ve message bilgilerini girmeye gerek yok çünkü zaten Result kısmında yazdık ve base() ile çağırdık
        public DataResult(T data, bool success, string message):base(success,message)
        {
            Data = data;
        }


            public DataResult(T data , bool success):base(success)
        {
            Data = data;

        }
        public T Data { get; }

    }
}
