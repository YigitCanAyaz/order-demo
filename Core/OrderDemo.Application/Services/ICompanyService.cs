using OrderDemo.Application.Features.Companies.Commands.CreateCompany;
using OrderDemo.Application.Features.Companies.Commands.UpdateCompany;
using OrderDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo.Application.Services
{
    public interface ICompanyService
    {
        Task CreateCompanyAsync(CreateCompanyCommand request);
        Task UpdateCompanyAsync(UpdateCompanyCommand request);
        IQueryable<Company> GetAll();
    }
}
