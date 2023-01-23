using MediatR;
using Microsoft.AspNetCore.Mvc;
using OrderDemo.Application.Features.Orders.Commands.CreateOrderCommand;
using OrderDemo.Presentation.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo.Presentation.Controllers
{
    public sealed class OrdersController : ApiController
    {
        public OrdersController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateOrder(CreateOrderCommand request)
        {
            CreateOrderCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
