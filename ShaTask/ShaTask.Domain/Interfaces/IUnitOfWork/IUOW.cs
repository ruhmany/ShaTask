using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaTask.Domain.Interfaces.IUnitOfWork
{
    public interface IUOW
    {
        int CommitChanges();
    }
}
