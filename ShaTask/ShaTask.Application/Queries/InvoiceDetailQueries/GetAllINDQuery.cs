using MediatR;
using ShaTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaTask.Application.Queries.InvoiceDetailQueries
{
    internal class GetAllINDQuery : IRequest<IEnumerable<InvoiceDetail>>
    {
    }
}
