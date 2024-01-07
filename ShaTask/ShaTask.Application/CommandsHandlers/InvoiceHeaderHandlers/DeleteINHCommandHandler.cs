using MediatR;
using Microsoft.Extensions.DependencyInjection;
using ShaTask.Application.Commands.InvoiceHeaderCommands;
using ShaTask.Domain.Interfaces.IRepositories;
using ShaTask.Domain.Interfaces.IUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaTask.Application.CommandsHandlers.InvoiceHeaderHandlers
{
    internal class DeleteINHCommandHandler : IRequestHandler<DeleteINHCommand>
    {
        private readonly IInvoiceDetail _invoiceHeader;
        private readonly IUOW _uOW;
        public DeleteINHCommandHandler(IServiceProvider provider)
        {
            _invoiceHeader = provider.GetRequiredService<IInvoiceDetail>();
            _uOW = provider.GetRequiredService<IUOW>();
        }
        public async Task Handle(DeleteINHCommand request, CancellationToken cancellationToken)
        {
            var ind = await _invoiceHeader.GetByIdAsync(request.ID);
            if (ind != null)
            {
                _invoiceHeader.Delete(ind);
                _uOW.CommitChanges();
            }
        }
    }
}
