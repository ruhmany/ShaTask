using ShaTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaTask.Domain.Interfaces.IRepositories
{
    public interface IInvoiceHeader
    {
        Task<InvoiceHeader> GetByIdAsync(long id);
        Task<List<InvoiceHeader>> GetAllAsync();
        Task AddAsync(InvoiceHeader entity);
        void Update(InvoiceHeader entity);
        void Delete(InvoiceHeader entity);
    }
}
