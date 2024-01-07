using MediatR;
using Microsoft.Extensions.DependencyInjection;
using ShaTask.Application.Commands.CashierCommands;
using ShaTask.Domain.Interfaces.IRepositories;
using ShaTask.Domain.Interfaces.IUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaTask.Application.CommandsHandlers.CashierHandlers
{
    internal class UpdateCashierCommandHandler : IRequestHandler<UpdateCashierCommand>
    {
        private readonly ICashierRepository _repository;
        private readonly IUOW _uow;
        public UpdateCashierCommandHandler(IServiceProvider provider)
        {
            _repository = provider.GetRequiredService<ICashierRepository>();
            _uow = provider.GetRequiredService<IUOW>();
        }
        public async Task Handle(UpdateCashierCommand request, CancellationToken cancellationToken)
        {
            var cashier = await _repository.GetByIdAsync(request.ID);
            if(cashier != null)
            {
                cashier.CashierName = request.CashierName;
                cashier.BranchID = request.BranchID;
                _repository.Update(cashier);
                _uow.CommitChanges();
            }           
        }
    }
}
