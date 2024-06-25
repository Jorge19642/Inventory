using System.ComponentModel.DataAnnotations;

namespace Inventary.backend.Model.Entity;

public class Sale
{
    [Key]
    public long Id { get; set; }
    public DateTime SaleDate { get; set; }
}
