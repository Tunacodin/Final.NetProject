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

        public Result(bool success, string message):this(success)
        {
            Message = message;
            
        }

        //overloading
        public Result(bool success)
        {
            
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
