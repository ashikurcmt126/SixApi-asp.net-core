using System.ComponentModel.DataAnnotations;

namespace SixApi.Dtos
{
    public class PlatformCreateDto
    {
        [Required]
        public string? PlatformName { get; set; }
    }
}
