using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using SixApi.Binders;

namespace SixApi.Models
{

    [ModelBinder(BinderType = typeof(PlatformModelBinder))]
    public class Platform
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? PlatformName { get; set; }
    }
}