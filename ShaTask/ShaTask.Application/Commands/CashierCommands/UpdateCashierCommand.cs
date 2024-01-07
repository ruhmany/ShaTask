using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaTask.Application.Commands.CashierCommands
{
    public class UpdateCashierCommand : IRequest
    {
        public int ID { get; set; }
        public string CashierName { get; set; }
        public int BranchID { get; set; }
    }
}
