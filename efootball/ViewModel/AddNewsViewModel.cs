using System.ComponentModel.DataAnnotations;

namespace efootball.ViewModel
{
    public class AddNewsViewModel
    {
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Body { get; set; } = string.Empty;
        [Required]
        public IFormFile Image { get; set; }
    }
}
