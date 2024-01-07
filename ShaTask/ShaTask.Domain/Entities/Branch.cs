using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaTask.Domain.Entities
{
    public class Branch
    {
        public int ID { get; set; }
        public string BranchName { get; set; }
        public int CityID { get; set; }
        public City City { get; set; }
        public List<Cashier> Cashiers { get; set; }
        public List<InvoiceHeader> InvoiceHeaders { get; set; }
    }
}
