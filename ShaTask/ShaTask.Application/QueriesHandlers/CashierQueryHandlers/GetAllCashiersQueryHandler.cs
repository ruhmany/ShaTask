using MediatR;
using ShaTask.Application.Queries.CashierQueries;
using ShaTask.Domain.Entities;
using ShaTask.Domain.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaTask.Application.QueriesHandlers.CashierQueryHandlers
{
    internal class GetAllCashiersQueryHandler : IRequestHandler<GetAllCashiersQuery, IEnumerable<Cashier>>
    {
        private readonly ICashierRepository _repository;

        public GetAllCashiersQueryHandler(ICashierRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Cashier>> Handle(GetAllCashiersQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllAsync();
        }
    }
}
