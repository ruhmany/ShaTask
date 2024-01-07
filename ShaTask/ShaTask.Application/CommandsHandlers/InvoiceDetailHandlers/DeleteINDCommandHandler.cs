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
    internal class DeleteINDCommandHandler : IRequestHandler<DeleteINDCommand>
    {
        private readonly IInvoiceDetail _invoiceDetail;
        private readonly IUOW _uOW;
        public DeleteINDCommandHandler(IServiceProvider provider)
        {
            _invoiceDetail = provider.GetRequiredService<IInvoiceDetail>();
            _uOW = provider.GetRequiredService<IUOW>();
        }
        public async Task Handle(DeleteINDCommand request, CancellationToken cancellationToken)
        {
            var ind = await _invoiceDetail.GetByIdAsync(request.ID);
            if (ind != null)
            {                
                _invoiceDetail.Delete(ind);
                _uOW.CommitChanges();
            }
        }
    }
}
