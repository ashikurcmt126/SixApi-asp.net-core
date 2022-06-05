using System;
using System.ComponentModel.DataAnnotations;

namespace SixApi.Dtos
{
	public class CommandUpdateDto
	{
        [Required]
        public string? HowTo { get; set; }

        [Required]
        [MaxLength(8)]
        public string? Platform { get; set; }

        [Required]
        public string? CommandLine { get; set; }
    }
}

