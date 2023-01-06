using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models;

[Table("clientes")]
public class Cliente
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {get; set;} = default!;

    [Column("nome", TypeName = "varchar(100)")]
    public string Nome {get; set;} = default!;

    [Column("email", TypeName = "varchar(100)")]
    public string Email {get; set;} = default!;

    [Column("telefone", TypeName = "varchar(15)")]
    public string? Telefone {get; set;}

    [Column("endereco", TypeName = "varchar(100)")]
    public string? Endereco {get; set;}
}