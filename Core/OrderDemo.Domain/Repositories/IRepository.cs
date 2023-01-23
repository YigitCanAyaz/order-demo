using Microsoft.EntityFrameworkCore;
using OrderDemo.Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo.Domain.Repositories
{
    public interface IRepository<T> where T: Entity
    {
        DbSet<T> Entity { get; set; }
    }
}
