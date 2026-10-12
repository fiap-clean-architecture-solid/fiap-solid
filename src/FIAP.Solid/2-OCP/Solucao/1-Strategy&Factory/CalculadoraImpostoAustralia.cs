using FIAP.Solid.OCP.Violacao;

namespace FIAP.Solid.OCP.Solucao.StrategyFactory;

public class CalculadoraImpostoAustralia : ICalculadoraImposto
{
    public bool PodeCalcular(string codigoPais) => codigoPais == "AUS";

    public decimal CalcularImposto(Pedido pedido)
    {
        var total = pedido.Itens.Sum(i => i.Quantidade * i.Produto.Preco) + pedido.Entrega;
        return total * 0.10m;
    }
}
