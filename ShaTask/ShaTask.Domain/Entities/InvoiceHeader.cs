using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaTask.Domain.Entities
{
    public class InvoiceHeader : BaseEntity
    {
        public long ID { get; set; }
        public string CustomerName { get; set; }
        public DateTime Invoicedate { get; set; }
        public int? CashierID { get; set; }
        public int BranchID { get; set; }
        public virtual Cashier Cashier { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual List<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
