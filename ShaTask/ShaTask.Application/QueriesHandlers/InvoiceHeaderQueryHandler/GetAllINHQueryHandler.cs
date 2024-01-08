using MediatR;
using ShaTask.Application.Queries.InvoiceHeaderQueries;
using ShaTask.Domain.Entities;
using ShaTask.Domain.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaTask.Application.QueriesHandlers.InvoiceHeaderQueryHandler
{
    internal class GetAllINHQueryHandler : IRequestHandler<GetAllINHQuery, IEnumerable<InvoiceHeader>>
    {
        private readonly IInvoiceHeader invoiceHeader;

        public GetAllINHQueryHandler(IInvoiceHeader invoiceHeader)
        {
            this.invoiceHeader = invoiceHeader;
        }

        public async Task<IEnumerable<InvoiceHeader>> Handle(GetAllINHQuery request, CancellationToken cancellationToken)
        {
            return await invoiceHeader.GetAllAsync();
        }
    }
}
