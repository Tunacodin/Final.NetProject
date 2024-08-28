using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    // Temel Void işlemleri için
    public interface IResult
    {
        // True - False
        bool Success { get; }

        // Result mesajı
        string Message { get; }




    }
}
