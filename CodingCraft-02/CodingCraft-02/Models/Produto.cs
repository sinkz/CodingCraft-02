using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingCraft_02.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public Guid ProdutoId { get; set; }
        public Guid CategoriaProdutoId { get; set; }
        public Guid GrupoProdutoId { get; set; }

        [Required]
        public string Nome { get; set; }
        [Required]
        public string Tamanho { get; set; }
        [Required]
        public string EstiloGola { get; set; }
        [Required]
        public decimal Preco { get; set; }
        [Required]
        public int Estoque { get; set; }

        public virtual CategoriaProduto CategoriasProduto { get; set; }
        public virtual GrupoProduto GruposProdutos { get; set; }
    }
}