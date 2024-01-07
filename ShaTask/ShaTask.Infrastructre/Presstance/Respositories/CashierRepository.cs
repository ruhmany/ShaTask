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
    public class CashierRepository : ICashierRepository
    {
        private readonly ApplicationDbContext _context;

        public CashierRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Cashier entity)
        {
            await _context.Cashier.AddAsync(entity);
        }

        public void Delete(Cashier entity)
        {
            _context.Cashier.Remove(entity);
        }

        public async Task<List<Cashier>> GetAllAsync()
        {
            return await _context.Cashier.Where(c=> !c.IsDeleted).ToListAsync();
        }

        public async Task<Cashier> GetByIdAsync(int id)
        {
            return await _context.Cashier.FirstOrDefaultAsync(c => c.ID == id);        
        }

        public void Update(Cashier entity)
        {
            _context.Cashier.Update(entity);
        }
    }
}
