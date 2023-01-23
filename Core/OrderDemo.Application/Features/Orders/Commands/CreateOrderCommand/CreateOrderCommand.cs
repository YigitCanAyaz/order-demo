using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo.Application.Features.Orders.Commands.CreateOrderCommand
{
    public sealed record CreateOrderCommand(
        string CompanyId,
        string ProductId,
        string CustomerName
    ) : IRequest<CreateOrderCommandResponse>;
}
