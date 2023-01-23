using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo.Application.Features.Products.Commands.CreateProduct
{
    // property mantığı ile çalıştığı için parametreler büyük harfle yazılır
    public sealed record CreateProductCommand(string CompanyId, string ProductName, decimal Stock, decimal Price)
}
