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
    public class InvoiceDetailRepository : IInvoiceDetail
    {
        private readonly ApplicationDbContext _context;

        public InvoiceDetailRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(InvoiceDetail entity)
        {
            await _context.InvoiceDetails.AddAsync(entity);
        }

        public void Delete(InvoiceDetail entity)
        {
            _context.InvoiceDetails.Remove(entity);
        }

        public async Task<List<InvoiceDetail>> GetAllAsync()
        {
            return await _context.InvoiceDetails.Where(c => !c.IsDeleted).ToListAsync();
        }

        public async Task<InvoiceDetail> GetByIdAsync(int id)
        {
            return await _context.InvoiceDetails.FirstOrDefaultAsync(ind => ind.ID == id);
        }

        public void Update(InvoiceDetail entity)
        {
            _context.InvoiceDetails.Update(entity);
        }
    }
}
