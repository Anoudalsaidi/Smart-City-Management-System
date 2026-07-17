using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartCity.API.Models
{
    public class ServiceRequest
    {
        [Key]
        public int ServiceRequestId { get; set; }

        [ForeignKey("Citizen")]
        public int CitizenId { get; set; }

        public Citizen? Citizen { get; set; }

        [ForeignKey("Service")]
        public int ServiceId { get; set; }

        public Service? Service { get; set; }

        public DateTime SubmissionDate { get; set; } = DateTime.Now;

        [Required]
        [StringLength(50)]
        public string Status { get; set; } = "Pending";

        [StringLength(500)]
        public string? Notes { get; set; }
    }
}