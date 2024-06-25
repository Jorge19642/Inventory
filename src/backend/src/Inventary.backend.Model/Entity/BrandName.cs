using System.ComponentModel.DataAnnotations;

namespace Inventary.backend.Model.Entity;

public class BrandName
{
    [Required]
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public required string Name { get; set; }
}
