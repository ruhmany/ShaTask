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
    internal class DeleteCashierCommandHandler : IRequestHandler<DeleteCashierCommand>
    {
        private readonly ICashierRepository _repository;
        private readonly IUOW _uow;
        public DeleteCashierCommandHandler(IServiceProvider provider)
        {
            _repository = provider.GetRequiredService<ICashierRepository>();
            _uow = provider.GetRequiredService<IUOW>();
        }
        public async Task Handle(DeleteCashierCommand request, CancellationToken cancellationToken)
        {
            var cashier = await _repository.GetByIdAsync(request.ID);
            if (cashier != null)
            {             
                _repository.Delete(cashier);
                _uow.CommitChanges();
            }
        }
    }
}
