using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFirst
{
    public  class Order
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid CustomerId { get; set;}
        public Guid EmployeeId { get; set; }
        public string OrderDate { get; set; }
        public string ShippedDate { get; set; }
        public Customer Customers { get; set; }
        public OrderDetails OrderDets { get; set; }

    }
}
