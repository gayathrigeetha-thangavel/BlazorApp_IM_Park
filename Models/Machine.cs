using System.ComponentModel.DataAnnotations;

namespace BlazorApp_IM_Park.Models
{
    public class Machine
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string? MachineName { get; set; }

        public string Status { get; set; } = "Offline";
        public DateTime LastUpdatedTime { get; set; } = DateTime.Now;
    }
}
