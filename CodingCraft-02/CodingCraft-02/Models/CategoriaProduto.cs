using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodingCraft_02.Models
{
    [Table("CategoriaProdutos")]
    public class CategoriaProduto
    {
        [Key]
        public Guid CategoriaProdutoId { get; set; }
        [Required]
        public string Categoria { get; set; }
        public virtual List<Produto> Produto { get; set; }
    }
}