using MediatR;
using Microsoft.Extensions.DependencyInjection;
using ShaTask.Application.Commands.InvoiceDetailCommands;
using ShaTask.Domain.Interfaces.IRepositories;
using ShaTask.Domain.Interfaces.IUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaTask.Application.CommandsHandlers.InvoiceDetailHandlers
{
    internal class UpdateINDCommandHandler : IRequestHandler<UpdateINDCommand>
    {
        private readonly IInvoiceDetail _invoiceDetail;
        private readonly IUOW _uOW;
        public UpdateINDCommandHandler(IServiceProvider provider)
        {
            _invoiceDetail = provider.GetRequiredService<IInvoiceDetail>();
            _uOW = provider.GetRequiredService<IUOW>();
        }
        public async Task Handle(UpdateINDCommand request, CancellationToken cancellationToken)
        {
            var ind = await _invoiceDetail.GetByIdAsync(request.ID);
            if (ind != null) 
            {
                ind.InvoiceHeaderID = request.InvoiceHeaderID;
                ind.ItemPrice = request.ItemPrice;
                ind.ItemName = request.ItemName;
                ind.ItemCount = request.ItemCount;
                _invoiceDetail.Update(ind);
                _uOW.CommitChanges();
            }
        }
    }
}
