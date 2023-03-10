using MediatR;
using OrderDemo.Application.Services;
using OrderDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo.Application.Features.Orders.Commands.CreateOrderCommand
{
    public sealed class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, CreateOrderCommandResponse>
    {
        private readonly IOrderService _orderService;
        private readonly ICompanyService _companyService;

        public CreateOrderCommandHandler(IOrderService orderService, ICompanyService companyService)
        {
            _orderService = orderService;
            _companyService = companyService;
        }

        public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            Company company = await _companyService.GetCompanyById(request.CompanyId);

            if (!company.ApprovalStatus) throw new Exception("Şirket aktif olmadığından sipariş alamıyoruz!");

            int orderStartHour = company.OrderStartTimeHour;
            int orderStartMinute = company.OrderStartTimeMinute;

            int orderFinishHour = company.OrderFinishTimeHour;
            int orderFinishMinute = company.OrderFinishTimeMinute;

            int nowHour = DateTime.Now.Hour;
            int nowMinute = DateTime.Now.Minute;

            if (orderStartHour < nowHour)
            {
                if (orderFinishHour >= nowHour && orderFinishMinute >= nowMinute)
                {
                    await _orderService.CreateOrder(request);
                }

            }

            else if (orderStartHour == nowHour)
            {
                if (orderStartMinute > nowMinute)
                {
                    await _orderService.CreateOrder(request);
                }
            }

            else
            {
                throw new Exception("Siparişiniz firmanın sipariş aldığı aralık dışında!");
            }

            return new();
        }
    }
}
