using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventary.backend.Model.Entity;

[Table("Product")]
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

    public required int BrandId { get; set; }
    public required double Stock { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public required decimal SellPrice { get; set; }

    [Column(TypeName ="decimal(10, 2)")]
    public required decimal BuyPrice { get; set; }

    [ForeignKey(nameof(BrandId))]
    public virtual BrandName Brand {get; set;} = null!;
}
