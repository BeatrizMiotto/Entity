using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models;

[Table("pedidos")]
public class Pedido
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {get; set;}

    [Column("id_cliente", TypeName = "integer")]
    public int IdCliente {get; set;}

    [ForeignKey("id_cliente")]
    public Cliente? Cliente {get; set;}

    [Column("id_carro", TypeName = "integer")]
    public int IdCarro {get; set;}

    [ForeignKey("id_carro")]
    public Carro? Carro {get; set;}

    [Column("data_locacao", TypeName = "datetime")]
    public DateTime DataLocacao {get; set;} = default!;

    [Column("data_entrega", TypeName = "datetime")]
    public DateTime DataEntrega {get; set;} = default!;

    [Column("dias_de_locacao", TypeName = "integer")]
    public int DiasDeLocacao {get; set;} = default!;
}