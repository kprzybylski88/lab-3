using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class FormModel
    {
        [Display(Name = "Nazwa elementu")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Opis elementu")]
        public string Description { get; set; }
        [Display(Name = "Element widoczny?")]
        public bool IsVisible { get; set; }
    }
}
