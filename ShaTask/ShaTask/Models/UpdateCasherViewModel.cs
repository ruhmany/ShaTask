using System.ComponentModel.DataAnnotations;

namespace ShaTask.Models
{
    public class UpdateCasherViewModel
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string CashierName { get; set; }
        [Required]
        public int BranchID { get; set; }
    }
}
