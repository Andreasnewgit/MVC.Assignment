using System.ComponentModel.DataAnnotations;

namespace MCV.Models
{
    public class CreatePersonViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string PhoneNumber { get; set; } = string.Empty;

    }
}
