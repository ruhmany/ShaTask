using MediatR;
using Microsoft.Extensions.DependencyInjection;
using ShaTask.Application.Commands.InvoiceDetailCommands;
using ShaTask.Domain.Entities;
using ShaTask.Domain.Interfaces.IRepositories;
using ShaTask.Domain.Interfaces.IUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaTask.Application.CommandsHandlers.InvoiceDetailHandlers
{
    internal class AddINDCommandHandler : IRequestHandler<AddINDCommand, InvoiceDetail>
    {
        private readonly IInvoiceDetail _invoiceDetail;
        private readonly IUOW _uOW;
        public AddINDCommandHandler(IServiceProvider provider)
        {
            _invoiceDetail = provider.GetRequiredService<IInvoiceDetail>();
            _uOW = provider.GetRequiredService<IUOW>();
        }
        public async Task<InvoiceDetail> Handle(AddINDCommand request, CancellationToken cancellationToken)
        {
            var ind = new InvoiceDetail
            {
                InvoiceHeaderID = request.InvoiceHeaderID,
                ItemName = request.ItemName,
                ItemCount = request.ItemCount,
                ItemPrice = request.ItemPrice
            };
            await _invoiceDetail.AddAsync(ind);
            _uOW.CommitChanges();
            return ind;
        }
    }
}
