using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }

        public Customer Client;

        public int ProductId { get; set; }

        public Product Product;

        public uint Quantity { get; set; }

        public enum Status { created = 1, paid = 2, delivered = 3 }
    }
}
