using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TesteJSL.Models
{
    [Table("PedidoProdutos")]
    public class PedidoProdutos
    {
        [Column("Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("IdPedido")]
        [Display(Name = "Pedido")]
        public int PedidoId { get; set; }

        [Column("IdProduto")]
        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }

        public Produto Produto { get; set; }

        [Column("Quantidade")]
        [Display(Name = "Qtde")]
        public int Quantidade { get; set; }

        [Column("ValorProduto")]
        [Display(Name = "Valor")]
        public float ValorProduto { get; set; }

        [Column("ValorTotal")]
        [Display(Name = "Total")]
        public float ValorTotal { get; set; }
    }
}
