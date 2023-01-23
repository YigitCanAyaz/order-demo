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
    public sealed class OrderQueryRepository : QueryRepository<Order>, IOrderQueryRepository
    {
        public OrderQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
