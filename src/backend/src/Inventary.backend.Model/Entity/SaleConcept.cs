using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventary.backend.Model.Entity;

[Table("SaleContext")]
public class SaleConcept
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public ulong Id { get; set; }
    public required long SaleId { get; set; }
    public required string ProductId { get; set; }

    //number of products
    public required double Quantity { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public required decimal UnitPrice { get; set; }

    [Column(TypeName ="decimal(10, 2)")]
    public required decimal Total { get; set; }

    [ForeignKey(nameof(ProductId))]
    public virtual Product Product { get; set; } = null!;

    [ForeignKey(nameof(SaleId))]
    public virtual Sale Sales { get; set; } = null!;
}
