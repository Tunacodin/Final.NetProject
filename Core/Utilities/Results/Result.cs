using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
      
        //constructor sayesinde set işlemi yapabildik ve set; kullanmadık

        // İlk constructor ın amacı hem message hem de success bilgisini döndürmektir, success için this.success ile 2. constructor ı çağırır. Busayede 2 constructor da çalışmış olur

        public Result(bool success, string message):this(success)
        {
            Message = message;
            
        }

        //overloading
        // 2. Cconstructor sadece success bilgisi döndürür , message bilgisi verilmediği durumda bu construcor çalışır
        public Result(bool success)
        {
            
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
