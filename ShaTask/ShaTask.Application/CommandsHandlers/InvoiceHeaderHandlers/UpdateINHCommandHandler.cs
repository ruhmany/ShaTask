using MediatR;
using Microsoft.Extensions.DependencyInjection;
using ShaTask.Application.Commands.CashierCommands;
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
    internal class UpdateINHCommandHandler : IRequestHandler<UpdateINHCommand>
    {
        private readonly IInvoiceHeader _invoiceHeader;
        private readonly IUOW _uow;
        public UpdateINHCommandHandler(IServiceProvider provider)
        {
            _invoiceHeader = provider.GetRequiredService<IInvoiceHeader>();
            _uow = provider.GetRequiredService<IUOW>();
        }
        public async Task Handle(UpdateINHCommand request, CancellationToken cancellationToken)
        {
            var ind = await _invoiceHeader.GetByIdAsync(request.ID);
            if (ind != null)
            {
                ind.CustomerName = request.CustomerName;
                ind.Invoicedate = request.Invoicedate;
                ind.CashierID = request.CashierID == 0 ? ind.CashierID: request.CashierID;
                ind.BranchID = request.BranchID == 0? ind.BranchID : request.BranchID;
                _invoiceHeader.Update(ind);
                _uow.CommitChanges();
            }
        }
    }
}
