using System.ComponentModel.DataAnnotations;

namespace Inventary.backend.Model.Entity;

public class SaleConcept
{
    [Key]
    public ulong Id { get; set; }
    public required Sale SaleId { get; set; }
    public required Product ProductId { get; set; }
    public required double Amount { get; set; }
    public required decimal UnitPrice { get; set; }
    public required decimal Total { get; set; }
}
