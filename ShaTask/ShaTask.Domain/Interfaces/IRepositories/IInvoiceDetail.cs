using ShaTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaTask.Domain.Interfaces.IRepositories
{
    public interface IInvoiceDetail
    {
        Task<InvoiceDetail> GetByIdAsync(int id);
        Task<List<InvoiceDetail>> GetAllAsync();
        Task AddAsync(InvoiceDetail entity);
        void Update(InvoiceDetail entity);
        void Delete(InvoiceDetail entity);
    }
}
