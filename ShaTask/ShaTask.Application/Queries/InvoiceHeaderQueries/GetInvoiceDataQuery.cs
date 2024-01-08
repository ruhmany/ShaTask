using MediatR;
using ShaTask.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaTask.Application.Queries.InvoiceHeaderQueries
{
    public class GetInvoiceDataQuery : IRequest<IEnumerable<InvoiceData>>
    {
    }
}
