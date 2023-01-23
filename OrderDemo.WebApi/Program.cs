using MediatR;
using Microsoft.EntityFrameworkCore;
using OrderDemo.Application.Services;
using OrderDemo.Domain;
using OrderDemo.Domain.Repositories.CompanyRepositories;
using OrderDemo.Domain.Repositories.OrderRepositories;
using OrderDemo.Domain.Repositories.ProductRepositories;
using OrderDemo.Persistence;
using OrderDemo.Persistence.Context;
using OrderDemo.Persistence.Repositories.CompanyRepositories;
using OrderDemo.Persistence.Repositories.OrderRepositories;
using OrderDemo.Persistence.Repositories.ProductRepositories;
using OrderDemo.Persistence.Services;
using OrderDemo.Presentation;

var builder = WebApplication.CreateBuilder(args);

#region DbContext
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));
// Add services to the container.
#endregion


#region Dependency Injection
builder.Services.AddScoped<IProductCommandRepository, ProductCommandRepository>();
builder.Services.AddScoped<IProductQueryRepository, ProductQueryRepository>();
builder.Services.AddScoped<ICompanyCommandRepository, CompanyCommandRepository>();
builder.Services.AddScoped<ICompanyQueryRepository, CompanyQueryRepository>();
builder.Services.AddScoped<IOrderCommandRepository, OrderCommandRepository>();
builder.Services.AddScoped<IOrderQueryRepository, OrderQueryRepository>();

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<IOrderService, OrderService>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddMediatR(typeof(OrderDemo.Application.AssemblyReference).Assembly);
#endregion

builder.Services.AddControllers()
    .AddApplicationPart(typeof(OrderDemo.Presentation.AssemblyReference).Assembly);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
