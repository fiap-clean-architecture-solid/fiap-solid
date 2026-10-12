using FIAP.Solid.OCP.Violacao;

namespace FIAP.Solid.OCP.Solucao.StrategyFactory;

public class CalculadoraSemImposto : ICalculadoraImposto
{
    public bool PodeCalcular(string codigoPais) => false;

    public decimal CalcularImposto(Pedido pedido) => 0m;
}
