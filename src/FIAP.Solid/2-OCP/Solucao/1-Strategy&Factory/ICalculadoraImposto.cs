using FIAP.Solid.OCP.Violacao;

namespace FIAP.Solid.OCP.Solucao.StrategyFactory;

public interface ICalculadoraImposto
{
    bool PodeCalcular(string codigoPais);
    decimal CalcularImposto(Pedido pedido);
}
