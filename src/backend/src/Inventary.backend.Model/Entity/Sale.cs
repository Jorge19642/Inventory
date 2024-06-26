using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventary.backend.Model.Entity;

[Table("Sale")]
public class Sale
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    public DateTime SaleDate { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal Total { get; set; }
}
