using OrderDemo.Domain.Entities;
using OrderDemo.Domain.Repositories.OrderRepositories;
using OrderDemo.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo.Persistence.Repositories.OrderRepositories
{
    public sealed class OrderCommandRepository : CommandRepository<Order>, IOrderCommandRepository
    {
        public OrderCommandRepository(AppDbContext context) : base(context)
        {
        }
    }
}
