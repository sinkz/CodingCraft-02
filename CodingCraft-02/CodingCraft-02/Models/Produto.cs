using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingCraft_02.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public long ProdutoId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public decimal Preco { get; set; }
    }
}