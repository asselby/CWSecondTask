using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFirst
{
    public class Customer
    {
        public  Guid Id { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
