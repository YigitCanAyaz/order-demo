using OrderDemo.Domain.Entities;
using OrderDemo.Domain.Repositories.ProductRepositories;
using OrderDemo.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo.Persistence.Repositories.ProductRepositories
{
    public sealed class ProductQueryRepository : QueryRepository<Product>, IProductQueryRepository
    {
        public ProductQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
