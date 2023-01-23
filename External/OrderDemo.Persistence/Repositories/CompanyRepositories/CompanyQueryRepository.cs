using OrderDemo.Domain.Entities;
using OrderDemo.Domain.Repositories.CompanyRepositories;
using OrderDemo.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo.Persistence.Repositories.CompanyRepositories
{
    public sealed class CompanyQueryRepository : QueryRepository<Company>, ICompanyQueryRepository
    {
        public CompanyQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
