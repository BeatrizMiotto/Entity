using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entity.Models;

[Table("cliente")]
public record Cliente
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get;set; }

    [Required(ErrorMessage = "Nome é obrigatório")]
    //[MaxLength(100)]
    [Column("nome", TypeName = "varchar(100)")]
    public string Nome { get;set; } = default!;

    [Column("email", TypeName = "varchar(100)")]
    public string Email { get;set; } = default!;
    
    [Column("telefone", TypeName = "varchar(100)")]
    public string Telefone { get;set; } = default!;

    [Column("endereco", TypeName = "varchar(100)")]
    public string Endereco { get;set; } = default!;

}