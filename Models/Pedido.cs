using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models;

[Table("pedido")]
public class Pedido
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {get; set;}

    [Column("id_cliente", TypeName = "INTEGER(100)")]
    public int IdCliente {get; set;}

    [Column("carro", TypeName = "varchar(100)")]
    public string? Carro {get; set;}

    [Column("data_locacao", TypeName = "varchar(100)")]
    public string? DataLocacao {get; set;}

    [Column("data_entrega", TypeName = "varchar(100)")]
    public string? DataEntrega {get; set;}
}