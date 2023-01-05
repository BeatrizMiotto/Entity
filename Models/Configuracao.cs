using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models;

[Table("configuracoes")]
public class Configuracao
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {get; set;}

    [Column("dias_de_locacao", TypeName = "date")]
    public DateTime DiasDeLocacao {get; set;}
}