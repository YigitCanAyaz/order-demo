using MediatR;
using Microsoft.AspNetCore.Mvc;
using OrderDemo.Application.Features.Companies.Commands.CreateCompany;
using OrderDemo.Application.Features.Companies.Commands.UpdateCompany;
using OrderDemo.Application.Features.Companies.Queries.GetAllCompanyQuery;
using OrderDemo.Presentation.Abstraction;

namespace OrderDemo.Presentation.Controllers;

public class CompaniesController : ApiController
{
    public CompaniesController(IMediator mediator) : base(mediator)
    {
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> CreateCompany(CreateCompanyCommand request)
    {
        CreateCompanyCommandResponse response = await _mediator.Send(request);
        return Ok(response);
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> UpdateCompany(UpdateCompanyCommand request)
    {
        UpdateCompanyCommandResponse response = await _mediator.Send(request);
        return Ok(response);
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> UpdateCompany()
    {
        GetAllCompanyQuery request = new();
        GetAllCompanyQueryResponse response = await _mediator.Send(request);
        return Ok(response);
    }
}
