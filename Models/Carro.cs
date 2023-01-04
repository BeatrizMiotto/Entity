using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models;

[Table("carro")]
public class Carro
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {get; set;}

    [Column("nome", TypeName = "varchar(100)")]
    public string? Nome {get; set;}

    [Column("marca", TypeName = "varchar(100)")]
    public string? Marca {get; set;}

    [Column("modelo", TypeName = "varchar(100)")]
    public string? Modelo {get; set;}
}