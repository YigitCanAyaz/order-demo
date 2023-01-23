using OrderDemo.Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo.Domain.Entities
{
    public sealed class Company : Entity
    {
        public string CompanyName { get; set; }
        public bool ApprovalStatus { get; set; }
        public TimeSpan OrderStartTime { get; set; } // sadece saat
        public TimeSpan OrderFinishTime { get; set; } // sadece saat

        public ICollection<Product> Products { get; set; }
    }
}
