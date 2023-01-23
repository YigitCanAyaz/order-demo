using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrderDemo.Domain.Entities;
using OrderDemo.Persistence.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo.Persistence.Configurations
{
    public sealed class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable(TableNames.Orders);
            builder.HasKey(p => p.Id);

            //// Bire çok ilişki
            builder
                .HasOne(p => p.Product)
                .WithMany(p => p.Orders)
                .HasForeignKey(p => p.ProductId);
        }
    }
}
