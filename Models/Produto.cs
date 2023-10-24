using System.ComponentModel.DataAnnotations;

namespace gestao_pedidos.Models
{
    public class Produto
    {
        [Key]
        [Display(Name = "Id")]
        public int ProdutoId { get; set; }

        [Display(Name = "Descricao")]
        public string Descricao { get; set; }

        [Display(Name = "Valor Unitario")]
        public decimal ValorUnitario { get; set; }

        [Display(Name = "Qtde em Estoque")]
        public int QuantidadeEmEstoque { get; set; }
    }
}
