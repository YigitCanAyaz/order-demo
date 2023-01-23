using OrderDemo.Domain.Primitives;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo.Domain.Entities
{
    public sealed class Product : Entity
    {
        public string ProductName { get; set; }
        public decimal Stock { get; set; }
        public decimal Price { get; set; }

        public string CompanyId { get; set; }
        public Company Company { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
