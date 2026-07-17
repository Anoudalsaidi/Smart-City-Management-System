using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartCity.API.Models
{
    public class Notification
    {
        [Key]
        public int NotificationId { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(300)]
        public string Message { get; set; } = string.Empty;

        public DateTime SentAt { get; set; } = DateTime.Now;

        public bool IsRead { get; set; } = false;

        [ForeignKey("Citizen")]
        public int CitizenId { get; set; }

        public Citizen? Citizen { get; set; }
    }
}