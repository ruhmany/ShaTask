using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaTask.Application.Commands.InvoiceDetailCommands
{
    internal class DeleteINDCommand : IRequest
    {
        public int ID { get; set; }
    }
}
