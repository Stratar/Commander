using System.ComponentModel.DataAnnotations;

namespace Commander.Models
{
    public class Command
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string HowTo { get; set; }
        [Required]
        public required string Line { get; set; }
        [Required]
        public required string Platform { get; set; }
    }


}