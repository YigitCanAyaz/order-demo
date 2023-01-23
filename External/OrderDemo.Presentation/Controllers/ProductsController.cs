using MediatR;
using Microsoft.AspNetCore.Mvc;
using OrderDemo.Application.Features.Products.Commands.CreateProduct;
using OrderDemo.Presentation.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo.Presentation.Controllers
{
    public sealed class ProductsController : ApiController
    {
        public ProductsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateProduct(CreateProductCommand request)
        {
            CreateProductCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
