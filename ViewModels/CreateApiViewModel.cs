using System.ComponentModel.DataAnnotations;

namespace  MyApi.ViewModels
{
    public class CreateApiViewModel
    {
        [Required]
        public string? Title { get; set; }
        
    }
}