using MediatR;
using ShaTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaTask.Application.Commands.InvoiceHeaderCommands
{
    public class AddINHCommand : IRequest<InvoiceHeader>
    {
        public string CustomerName { get; set; }
        public DateTime Invoicedate { get; set; }
        public int? CashierID { get; set; }
        public int BranchID { get; set; }
    }
}
