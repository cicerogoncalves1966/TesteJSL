using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TesteJSL.Models
{
    [Table("tbProduto")]
    public class Produto
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string? Nome { get; set; }

        [Column("ValorProduto")]
        [Display(Name = "Valor")]
        public float ValorProduto { get; set; }

        [Column("Ativo")]
        [Display(Name = "Status")]
        public string? Ativo { get; set; }
    }
}
