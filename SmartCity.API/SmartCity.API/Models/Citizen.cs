using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartCity.API.Models
{
    public class Citizen
    {
        [Key]
        public int CitizenId { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        public string NationalId { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Phone]
        [StringLength(20)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [StringLength(250)]
        public string Address { get; set; } = string.Empty;

        [ForeignKey("CityZone")]
        public int CityZoneId { get; set; }

        public CityZone? CityZone { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Navigation Properties
        public ICollection<ServiceRequest> ServiceRequests { get; set; } = new List<ServiceRequest>();
        public ICollection<Complaint> Complaints { get; set; } = new List<Complaint>();
        public ICollection<UtilityBill> UtilityBills { get; set; } = new List<UtilityBill>();
        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
    }
}