using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TesteJSL.Models
{
    [Table("tbPedido")]
    public class Pedido
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("IdCliente")]
        [Display(Name = "Cliente")]
        public int IdCliente { get; set; }

        public Cliente? Cliente { get; set; }

        [Column("DataPedido")]
        [Display(Name = "Data Pedido")]
        public DateTime DataPedido { get; set; }

        [Column("TotalPedido")]
        [Display(Name = "Valor Total")]
        public float TotalPedido { get; set; }

        [Column("Status")]
        [Display(Name = "Status")]
        public string? Status { get; set; }
    }
}
