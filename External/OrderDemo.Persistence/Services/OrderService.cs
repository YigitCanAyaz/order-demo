using OrderDemo.Application.Features.Orders.Commands.CreateOrderCommand;
using OrderDemo.Application.Services;
using OrderDemo.Domain;
using OrderDemo.Domain.Entities;
using OrderDemo.Domain.Repositories.OrderRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo.Persistence.Services
{
    public sealed class OrderService : IOrderService
    {
        private readonly IOrderCommandRepository _orderCommandRepository;
        private readonly IUnitOfWork _unitOfWork;

        public OrderService(IOrderCommandRepository orderCommandRepository, IUnitOfWork unitOfWork)
        {
            _orderCommandRepository = orderCommandRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task CreateOrder(CreateOrderCommand request)
        {
            Order order = new()
            {
                Id = Guid.NewGuid().ToString(),
                CreatedDate = DateTime.Now,
                CustomerName = request.CustomerName,
                OrderDate = DateTime.Now,
                ProductId = request.ProductId
            };

            await _orderCommandRepository.AddAsync(order);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
