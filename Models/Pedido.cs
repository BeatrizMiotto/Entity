using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models;

[Table("pedidos")]
public class Pedido
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {get; set;}

    [Column("id_cliente", TypeName = "integer not null")]
    public int IdCliente {get; set;}

    [Column("id_carro", TypeName = "integer not null")]
    public int Carro {get; set;}

    [Column("data_locacao", TypeName = "date")]
    public DateTime DataLocacao {get; set;}

    [Column("data_entrega", TypeName = "date")]
    public DateTime DataEntrega {get; set;}
}