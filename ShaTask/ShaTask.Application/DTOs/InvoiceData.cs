using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaTask.Application.DTOs
{
    public class InvoiceData
    {
        public long ID { get; set; }
        public string CustomerName { get; set; }
        public DateTime Invoicedate { get; set; }
        public string CashierName { get; set; }
        public string BranchName { get; set; }
        public List<string> ItemsNames { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
