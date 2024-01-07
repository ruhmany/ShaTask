using MediatR;
using Microsoft.Extensions.DependencyInjection;
using ShaTask.Application.Commands.CashierCommands;
using ShaTask.Domain.Entities;
using ShaTask.Domain.Interfaces.IRepositories;
using ShaTask.Domain.Interfaces.IUnitOfWork;

namespace ShaTask.Application.CommandsHandlers.CashierHandlers
{
    public class AddCashierCommandHandler : IRequestHandler<AddCashierCommand, Cashier>
    {
        private readonly ICashierRepository _repository;
        private readonly IUOW _uow;
        public AddCashierCommandHandler(IServiceProvider provider)
        {
            _repository = provider.GetRequiredService<ICashierRepository>();
            _uow = provider.GetRequiredService<IUOW>();
        }
        public async Task<Cashier> Handle(AddCashierCommand request, CancellationToken cancellationToken)
        {
            var cashier = new Cashier
            {
                CashierName = request.CashierName,
                BranchID = request.BranchID
            };
            await _repository.AddAsync(cashier);
            _uow.CommitChanges();
            return cashier;
        }
    }
}
