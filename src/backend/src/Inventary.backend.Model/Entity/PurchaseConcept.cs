using System.ComponentModel.DataAnnotations.Schema;

namespace Inventary.backend.Model.Entity;

[Table("PurchaseConcept")]
public class PurchaseConcept
{
    public long Id { get; set; }
    public long PurchaseId { get; set; }
    public string ProductId { get; set; } = null!;
    public double Quantity { get; set; }

    [Column(TypeName ="decimal(10, 2)")]
    public decimal UnitPrice { get; set; }

    [Column(TypeName ="decimal(10, 2)")]
    public decimal Total { get; set; }

    [ForeignKey(nameof(PurchaseId))]
    public virtual Purchase Purchase { get; set; } = null!;

    [ForeignKey(nameof(ProductId))]
    public virtual Product Produts { get; set; } = null!;
}
