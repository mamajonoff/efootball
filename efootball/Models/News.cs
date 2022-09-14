using System.ComponentModel.DataAnnotations;

namespace efootball.Models
{
    public class News
    {
        [Key, Required]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Body { get; set; } = string.Empty;
        [Required]
        public string Images { get; set; } = string.Empty;
        public DateTime CreatedTime { get; set; }
    }
}
