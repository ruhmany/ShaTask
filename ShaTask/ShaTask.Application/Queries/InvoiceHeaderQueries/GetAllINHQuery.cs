using MediatR;
using ShaTask.Domain.Entities;

namespace ShaTask.Application.Queries.InvoiceHeaderQueries
{
    public class GetAllINHQuery : IRequest<IEnumerable<InvoiceHeader>>
    {
    }
}
