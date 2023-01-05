using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models;

[Table("carros")]
public class Carro
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {get; set;}

    [Column("nome", TypeName = "varchar(100)")]
    public string? Nome {get; set;}

    [Column("id_marca", TypeName = "integer not null")]
    public int Marca {get; set;}

    [Column("id_modelo", TypeName = "integer not null")]
    public int Modelo {get; set;}
}