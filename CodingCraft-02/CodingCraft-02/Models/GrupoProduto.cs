using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodingCraft_02.Models
{
    [Table("GrupoProdutos")]
    public class GrupoProduto
    {
        [Key]
        public Guid GrupoProdutoId { get; set; }
        [Required]
        public string Grupo { get; set; }
        public virtual List<Produto> Produto { get; set; }
        public virtual List<CategoriaProduto> CategoriaProdutos { get; set; }
    }
}