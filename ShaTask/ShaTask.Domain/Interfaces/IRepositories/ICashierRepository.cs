using ShaTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaTask.Domain.Interfaces.IRepositories
{
    public interface ICashierRepository
    {
        Task<Cashier> GetByIdAsync(int id);
        Task<List<Cashier>> GetAllAsync();
        Task AddAsync(Cashier entity);
        void Update(Cashier entity);
        void Delete(Cashier entity);
    }
}
