using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entity.Models;

[Table("marca")]
public record Marca
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get;set; }

    [Required(ErrorMessage = "Nome é obrigatório")]
    //[MaxLength(100)]
    [Column("nome", TypeName = "varchar(100)")]
    public string Nome { get;set; } = default!;
}