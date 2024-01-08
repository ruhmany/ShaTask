using Microsoft.EntityFrameworkCore;
using ShaTask.Domain.Entities;
using ShaTask.Domain.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaTask.Infrastructre.Presstance.Respositories
{
    public class InvoiceHeaderRepository : IInvoiceHeader
    {
        private readonly ApplicationDbContext _context;

        public InvoiceHeaderRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(InvoiceHeader entity)
        {
            await _context.InvoiceHeader.AddAsync(entity);
        }

        public void Delete(InvoiceHeader entity)
        {
            _context.InvoiceHeader.Remove(entity);
        }

        public async Task<List<InvoiceHeader>> GetAllAsync()
        {
            return await _context.InvoiceHeader.Where(c => !c.IsDeleted).ToListAsync();
        }

        public async Task<InvoiceHeader> GetByIdAsync(long id)
        {
            return await _context.InvoiceHeader.FirstOrDefaultAsync(inh => inh.ID == id);
        }

        public void Update(InvoiceHeader entity)
        {
            _context.InvoiceHeader.Update(entity);
        }
    }
}
