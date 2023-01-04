using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entity.Models;

[Table("pedido")]
public record Pedido
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get;set; }

    [Column("id_cliente", TypeInt = "interger")]
    public string IdCliente { get;set; } = default!;

    [Column("carro", TypeName = "varchar(100)")]
    public string Carro { get;set; } = default!;
    
    [Column("data_locacao", TypeName = "varchar(10)")]
    public string DataLocacao { get;set; } = default!;

    [Column("data_entrega", TypeName = "varchar(10)")]
    public string DataEntrega { get;set; } = default!;

}