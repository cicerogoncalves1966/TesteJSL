using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteJSL.Models
{
    [Table("tbCliente")]
    public class Cliente
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }
 
        [Column("Nome")]
        [Display(Name = "Nome")]
        public string? Nome { get; set; }

        [Column("Ativo")]
        [Display(Name = "Status")]
        public string? Ativo { get; set; }
    }
}
