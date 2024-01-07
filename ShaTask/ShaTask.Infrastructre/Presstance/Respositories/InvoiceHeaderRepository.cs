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
            await _context.InvoiceHeaders.AddAsync(entity);
        }

        public void Delete(InvoiceHeader entity)
        {
            _context.InvoiceHeaders.Remove(entity);
        }

        public async Task<List<InvoiceHeader>> GetAllAsync()
        {
            return await _context.InvoiceHeaders.Where(c => !c.IsDeleted).ToListAsync();
        }

        public async Task<InvoiceHeader> GetByIdAsync(int id)
        {
            return await _context.InvoiceHeaders.FirstOrDefaultAsync(inh => inh.ID == id);
        }

        public void Update(InvoiceHeader entity)
        {
            _context.InvoiceHeaders.Update(entity);
        }
    }
}
