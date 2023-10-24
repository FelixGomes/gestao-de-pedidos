namespace gestao_pedidos.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public int ClienteId { get; set; } // Referência ao cliente
        public List<ItemPedido> Itens { get; set; } // Lista de itens do pedido
        public decimal ValorTotal { get; set; }
        public DateTime DataEntrega { get; set; }
        public string FormaDePagamento { get; set; }
    }
}
