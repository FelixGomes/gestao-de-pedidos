using System.ComponentModel.DataAnnotations;

namespace gestao_pedidos.Models
{
    public class Produto
    {
        [Key]
        [Display(Name = "Id")]
        public int ProdutoId { get; set; }
        public string Descricao { get; set; }
        public decimal ValorUnitario { get; set; }
        public int QuantidadeEmEstoque { get; set; }
    }
}
