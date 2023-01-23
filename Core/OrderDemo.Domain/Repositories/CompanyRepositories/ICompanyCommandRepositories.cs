using OrderDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo.Domain.Repositories.CompanyRepositories
{
    public interface ICompanyCommandRepositories : ICommandRepository<Company>
    {
    }
}
