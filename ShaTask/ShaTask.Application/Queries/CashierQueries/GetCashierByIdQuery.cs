using MediatR;
using ShaTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaTask.Application.Queries.CashierQueries
{
    public class GetCashierByIdQuery : IRequest<Cashier>
    {
        public int Id { get; set; }
    }
}
