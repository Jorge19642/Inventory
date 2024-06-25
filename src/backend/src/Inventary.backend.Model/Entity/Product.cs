using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventary.backend.Model.Entity;

public class Product
{
    [Key]
    [MaxLength(14)]
    public required string Id { get; set; }

    [Required]
    [StringLength(50)]
    public required string Name { get; set; }

    [StringLength(80)]
    public required string Description { get; set; }

    public required BrandName Brand { get; set; }
    public required double Stock { get; set; }
    public required decimal SellPrice { get; set; }
    public required decimal BuyPrice { get; set; }
}
