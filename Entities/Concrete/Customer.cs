using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public string CustomerName {  get; set; }
        public string CustomerID { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerEmail { get; set; }

        
    }
}
