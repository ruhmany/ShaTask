using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaTask.Domain.Entities
{
    public class Branch : BaseEntity
    {        
        public string BranchName { get; set; }
        public int CityID { get; set; }
        public virtual City City { get; set; }
        public virtual List<Cashier> Cashiers { get; set; }
        public virtual List<InvoiceHeader> InvoiceHeaders { get; set; }
    }
}
