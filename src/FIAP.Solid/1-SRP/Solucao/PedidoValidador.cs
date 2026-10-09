namespace FIAP.Solid.SRP.Solucao;

public class PedidoValidador : IPedidoValidador
{
    public void Validar(Pedido pedido)
    {
        if (pedido.Itens == null || pedido.Itens.Count == 0)
            throw new InvalidOperationException("Pedido sem itens.");

        if (pedido.Cliente == null || string.IsNullOrWhiteSpace(pedido.Cliente.Email))
            throw new InvalidOperationException("Cliente inválido.");
    }
}
