using System.ComponentModel.DataAnnotations;

namespace ShaTask.Models
{
    public class AddCashierViewModel
    {
        [Required]
        public string CashierName { get; set; }

        [Required]
        public int BranchID { get; set; }
    }
}
