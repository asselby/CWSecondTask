using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFirst
{
  public  class OrderDetails
    {
        public Guid Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public Order Order{ get; set;}
        public Product Product { get; set; }
        public virtual ICollection<Order> Orders { get; set;}
    }
}
