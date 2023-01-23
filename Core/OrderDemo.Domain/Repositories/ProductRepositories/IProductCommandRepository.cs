using OrderDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo.Domain.Repositories.ProductRepositories
{
    public interface IProductCommandRepository : ICommandRepository<Product>
    {
    }
}
