namespace WebApplication2.Models;

using System.ComponentModel.DataAnnotations;

public record AddProductInWarehouse
(
    [Required]
    int IdProduct,
    
    [Required] 
    int IdWarehouse,
    
    
    [Required]
    [Range(1,int.MaxValue,ErrorMessage = "Ilość musi być większa od 0!")]
    int Amount,

    [Required] 
    DateTime CreatedAt
);