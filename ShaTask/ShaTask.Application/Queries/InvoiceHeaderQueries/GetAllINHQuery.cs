using MediatR;
using ShaTask.Domain.Entities;

namespace ShaTask.Application.Queries.InvoiceHeaderQueries
{
    internal class GetAllINHQuery : IRequest<IEnumerable<InvoiceHeader>>
    {
    }
}
