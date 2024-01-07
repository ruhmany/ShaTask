using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaTask.Domain.Entities
{
    public class Cashier : BaseEntity
    {        
        public string CashierName { get; set; }
        public int BranchID { get; set; }
        public virtual Branch Branch { get; set; }
    }
}
