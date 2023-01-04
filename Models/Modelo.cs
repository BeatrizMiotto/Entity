using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entity.Models;

[Table("modelo")]
public record Modelo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get;set; }

    [Required(ErrorMessage = "Nome é obrigatório")]
    //[MaxLength(100)]
    [Column("nome", TypeName = "varchar(100)")]
    public string Nome { get;set; } = default!;
}