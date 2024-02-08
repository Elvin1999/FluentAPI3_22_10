using FluentAPI3_22_10.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI3_22_10.Domain.Abstractions
{
    public interface ICustomerRepository:IRepository<Customer>
    {
    }
}
