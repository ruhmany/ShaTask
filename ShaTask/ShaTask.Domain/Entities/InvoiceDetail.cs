using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaTask.Domain.Entities
{
    public class InvoiceDetail : BaseEntity
    {
        public long ID { get; set; }
        public long InvoiceHeaderID { get; set; }
        public string ItemName { get; set; }
        public double ItemCount { get; set; }
        public double ItemPrice { get; set; }
        public virtual InvoiceHeader InvoiceHeader { get; set; }
    }
}
