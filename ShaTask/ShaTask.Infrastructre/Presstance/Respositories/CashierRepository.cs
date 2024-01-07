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
            await _context.Cashiers.AddAsync(entity);
        }

        public void Delete(Cashier entity)
        {
            _context.Cashiers.Remove(entity);
        }

        public async Task<List<Cashier>> GetAllAsync()
        {
            return await _context.Cashiers.ToListAsync();
        }

        public async Task<Cashier> GetByIdAsync(int id)
        {
            return await _context.Cashiers.FirstOrDefaultAsync(c => c.ID == id);        
        }

        public void Update(Cashier entity)
        {
            _context.Cashiers.Update(entity);
        }
    }
}
