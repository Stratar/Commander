using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Dtos
{
    public class CommandUpdateDto
    {
        [Required]
        public required string HowTo { get; set; }
        [Required]
        public required string Line { get; set; }
        [Required]
        public required string Platform { get; set; }
    }
}