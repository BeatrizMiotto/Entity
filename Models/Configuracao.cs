using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entity.Models;

[Table("configuracao")]
public record Configuracao
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get;set; }

    [Column("dias_de_locacao", TypeName = "varchar(10)")]
    public string Carro { get;set; } = default!;

}