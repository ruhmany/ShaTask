using MediatR;
using ShaTask.Application.DTOs;
using ShaTask.Application.Queries.InvoiceHeaderQueries;
using ShaTask.Domain.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaTask.Application.QueriesHandlers.InvoiceHeaderQueryHandler
{
    internal class GetInvoiceDataQueryHandler : IRequestHandler<GetInvoiceDataQuery, IEnumerable<InvoiceData>>
    {
        private readonly IInvoiceHeader _header;

        public GetInvoiceDataQueryHandler(IInvoiceHeader header)
        {
            _header = header;
        }

        public async Task<IEnumerable<InvoiceData>> Handle(GetInvoiceDataQuery request, CancellationToken cancellationToken)
        {
            var invoices = await _header.GetAllAsync();
            var result = new List<InvoiceData>();
            foreach ( var invoice in invoices)
            {
                result.Add(new InvoiceData 
                {
                    ID = invoice.ID,
                    CustomerName = invoice.CustomerName,
                    CashierName = invoice.Cashier?.CashierName,
                    BranchName = invoice.Branch?.BranchName,
                    ItemsNames = invoice.InvoiceDetails?.Select(n=> n.ItemName).ToList(),
                    TotalPrice = (invoice.InvoiceDetails.Sum(item => (decimal)item.ItemPrice))
                });
            }
            return result;
        }
    }
}
