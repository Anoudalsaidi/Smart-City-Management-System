using System.ComponentModel.DataAnnotations;

namespace SmartCity.API.Models
{
    public class CityZone
    {
        [Key]
        public int CityZoneId { get; set; }

        [Required]
        [StringLength(100)]
        public string ZoneName { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string District { get; set; } = string.Empty;

        [StringLength(300)]
        public string? Description { get; set; }

        public bool IsActive { get; set; } = true;

        // Navigation Property
        public ICollection<Citizen> Citizens { get; set; } = new List<Citizen>();
    }
}