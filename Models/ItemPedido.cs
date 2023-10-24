namespace gestao_pedidos.Models
{
    public class ItemPedido
    {
        public int ItemPedidoId { get; set; }
        public int ProdutoId { get; set; } // Referência ao produto
        public int Quantidade { get; set; }
        public decimal ValorTotalItem { get; set; }
    }
}
