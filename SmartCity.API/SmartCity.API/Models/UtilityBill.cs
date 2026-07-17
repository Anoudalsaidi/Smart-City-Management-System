using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartCity.API.Models
{
    public class UtilityBill
    {
        [Key]
        public int UtilityBillId { get; set; }

        [Required]
        [StringLength(50)]
        public string BillType { get; set; } = string.Empty;

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than 0.")]
        public decimal Amount { get; set; }

        public DateTime DueDate { get; set; }

        public bool IsPaid { get; set; } = false;

        [ForeignKey("Citizen")]
        public int CitizenId { get; set; }

        public Citizen? Citizen { get; set; }
    }
}