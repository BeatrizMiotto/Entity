using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models;

[Table("configuracao")]
public class Configuracao
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {get; set;}

    [Column("dias_de_locacao", TypeName = "varchar(10)")]
    public string? DiasDeLocacao {get; set;}
}