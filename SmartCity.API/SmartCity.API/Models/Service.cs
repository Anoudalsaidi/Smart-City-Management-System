using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartCity.API.Models
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }

        [Required]
        [StringLength(100)]
        public string ServiceName { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Description { get; set; }

        [Range(1, 365)]
        public int EstimatedProcessingDays { get; set; }

        public bool IsActive { get; set; } = true;

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        public Department? Department { get; set; }

        // Navigation Property
        public ICollection<ServiceRequest> ServiceRequests { get; set; } = new List<ServiceRequest>();
    }
}