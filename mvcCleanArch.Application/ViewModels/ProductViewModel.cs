using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace mvcCleanArch.Application.ViewModels;

public class ProdcutViewModel
{
    public int Id {get; set;}

    // Create DataAnnotations for Form Validation
    [Required(ErrorMessage = "The Name is Required")]
    [MinLength(5)]
    [MaxLength(100)]
    [DisplayName("Name")]
    public string Name {get; set;}

    [Required(ErrorMessage = "The Description is Required")]
    [MinLength(10)]
    [MaxLength(200)]
    [DisplayName("Description")]
    public string Description {get; set;}

    [Required(ErrorMessage = "The Price is Required")]
    [Range(1, 99999.99)]
    [DisplayName("Price")]
    public decimal Price {get; set;}    
}