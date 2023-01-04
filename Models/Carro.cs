using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entity.Models;

[Table("carro")]
public record Carro
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get;set; }

    [Required(ErrorMessage = "Nome é obrigatório")]
    //[MaxLength(100)]
    [Column("nome", TypeName = "varchar(100)")]
    public string Nome { get;set; } = default!;

    [Column("marca", TypeName = "varchar(100)")]
    public string Marca { get;set; } = default!;
    
    [Column("modelo", TypeName = "varchar(100)")]
    public string Modelo { get;set; } = default!;
}