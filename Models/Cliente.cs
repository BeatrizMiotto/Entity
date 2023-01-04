using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models;

[Table("clientes")]
public class Cliente
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {get; set;}

    [Required(ErrorMessage = "Nome é obrigatório")]
    [Column("nome", TypeName = "varchar(100)")]
    public string? Nome {get; set;}

    [Column("email", TypeName = "varchar(50)")]
    public string? Email {get; set;}

    [Column("telefone", TypeName = "varchar(11)")]
    public string? Telefone {get; set;}

    [Column("endereco", TypeName = "varchar(100)")]
    public string? Endereco {get; set;}
}