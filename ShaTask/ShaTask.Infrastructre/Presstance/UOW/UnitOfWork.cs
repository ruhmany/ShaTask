using ShaTask.Domain.Interfaces.IUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaTask.Infrastructre.Presstance.UOW
{
    public class UnitOfWork : IUOW
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public int CommitChanges()
        {
            return _context.SaveChanges();
        }
    }
}
