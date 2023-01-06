using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models;

[Table("carros")]
public class Carro
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {get; set;}

    [Column("marca", TypeName = "varchar(100)")]
    public string Marca {get; set;} = default!;

    [Column("modelo", TypeName = "varchar(100)")]
    public string Modelo {get; set;} = default!;

}