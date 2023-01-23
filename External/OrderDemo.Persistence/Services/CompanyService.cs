using OrderDemo.Application.Features.Companies.Commands.CreateCompany;
using OrderDemo.Application.Features.Companies.Commands.UpdateCompany;
using OrderDemo.Application.Services;
using OrderDemo.Domain;
using OrderDemo.Domain.Entities;
using OrderDemo.Domain.Repositories.CompanyRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo.Persistence.Services
{
    public sealed class CompanyService : ICompanyService
    {
        private readonly ICompanyCommandRepository _companyCommandRepository;
        private readonly ICompanyQueryRepository _companyQueryRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CompanyService(ICompanyCommandRepository companyCommandRepositories, ICompanyQueryRepository companyQueryRepository, IUnitOfWork unitOfWork)
        {
            _companyCommandRepository = companyCommandRepositories;
            _companyQueryRepository = companyQueryRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task CreateCompanyAsync(CreateCompanyCommand request)
        {
            Company company = new()
            {
                Id = Guid.NewGuid().ToString(),
                ApprovalStatus = false,
                CompanyName = request.CompanyName,
                CreatedDate = DateTime.Now,
                OrderStartTime = request.OrderStartTime,
                OrderFinishTime = request.OrderFinishTime,
            };

            await _companyCommandRepository.AddAsync(company);
            await _unitOfWork.SaveChangesAsync();
        }

        public IQueryable<Company> GetAll()
        {
            return _companyQueryRepository.GetAll();
        }

        public async Task UpdateCompanyAsync(UpdateCompanyCommand request)
        {
            var company = await _companyQueryRepository.GetFirstById(request.CompanyId);

            if (company == null) throw new Exception("Şirket kaydı bulunamadı!");
            if (company.ApprovalStatus) throw new Exception("Şirket zaten onaylı!");

            company.ApprovalStatus = true;
            company.OrderStartTime = request.OrderStartTime;

            _companyCommandRepository.Update(company);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
