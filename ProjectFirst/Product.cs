using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFirst
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
