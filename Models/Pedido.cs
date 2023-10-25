using System.ComponentModel.DataAnnotations;

namespace gestao_pedidos.Models
{
    public class Pedido
    {
        [Key]
        [Display(Name = "Id")]
        public int PedidoId { get; set; }

        [Display(Name = "Cliente Id")]
        public int ClienteId { get; set; } // Referência ao cliente
        public List<ItemPedido> Itens { get; set; } // Lista de itens do pedido

        [Display(Name = "Valor Total")]
        public Double ValorTotal { get; set; }

        [Display(Name = "Data de Entrega")]
        public DateTime DataEntrega { get; set; }

        [Display(Name = "Forma de Pagamento")]
        public string FormaDePagamento { get; set; }
    }
}
