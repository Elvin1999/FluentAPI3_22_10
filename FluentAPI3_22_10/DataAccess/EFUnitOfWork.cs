using FluentAPI3_22_10.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI3_22_10.DataAccess
{
    public class EFUnitOfWork : IUnitOfWork
    {
        public ICustomerRepository CustomerRepository => new EFCustomerRepository();

        public IOrderRepository OrderRepository => new EFOrderRepository();
    }
}
