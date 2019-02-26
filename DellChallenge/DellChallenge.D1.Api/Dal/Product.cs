using System.ComponentModel.DataAnnotations;

namespace DellChallenge.D1.Api.Dal
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
    }
}