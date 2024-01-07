using MediatR;
using Microsoft.Extensions.DependencyInjection;
using ShaTask.Application.Commands.InvoiceHeaderCommands;
using ShaTask.Domain.Entities;
using ShaTask.Domain.Interfaces.IRepositories;
using ShaTask.Domain.Interfaces.IUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaTask.Application.CommandsHandlers.InvoiceHeaderHandlers
{
    internal class AddINHCommandHandler : IRequestHandler<AddINHCommand, InvoiceHeader>
    {
        private readonly IInvoiceHeader _invoiceHeader;
        private readonly IUOW _uow;
        public AddINHCommandHandler(IServiceProvider provider)
        {
            _invoiceHeader = provider.GetRequiredService<IInvoiceHeader>();
            _uow = provider.GetRequiredService<IUOW>();
        }
        public async Task<InvoiceHeader> Handle(AddINHCommand request, CancellationToken cancellationToken)
        {
            var inh = new InvoiceHeader
            {
                CustomerName = request.CustomerName,
                Invoicedate = request.Invoicedate,
                CashierID = request.CashierID,
                BranchID = request.BranchID
            };
            await _invoiceHeader.AddAsync(inh);
            _uow.CommitChanges();
            return inh;
        }
    }
}
