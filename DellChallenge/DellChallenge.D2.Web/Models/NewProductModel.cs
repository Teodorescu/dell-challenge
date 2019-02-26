using System.ComponentModel.DataAnnotations;

namespace DellChallenge.D2.Web.Models
{
    public class NewProductModel
    {
        [Required(ErrorMessage = "Name is required")]
        [MinLength(2), MaxLength(100)]
        public string Name { get; set; }
        public string Category { get; set; }
    }
}
