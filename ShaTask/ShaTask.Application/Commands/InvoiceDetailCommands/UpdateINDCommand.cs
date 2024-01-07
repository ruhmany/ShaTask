using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaTask.Application.Commands.InvoiceDetailCommands
{
    internal class UpdateINDCommand : IRequest
    {
        public int ID { get; set; }
        public long InvoiceHeaderID { get; set; }
        public string ItemName { get; set; }
        public float ItemCount { get; set; }
        public float ItemPrice { get; set; }
    }
}
