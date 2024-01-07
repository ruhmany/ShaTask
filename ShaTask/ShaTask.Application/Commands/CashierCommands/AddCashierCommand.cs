using MediatR;
using ShaTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaTask.Application.Commands.CashierCommands
{
    public class AddCashierCommand : IRequest<Cashier>
    {
        public string CashierName { get; set; }
        public int BranchID { get; set; }
    }
}
