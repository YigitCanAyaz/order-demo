using OrderDemo.Domain.Primitives;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo.Domain.Entities
{
    public sealed class Order : Entity
    {
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }

        public string ProductId { get; set; }
        public Product Product { get; set; }
    }
}
