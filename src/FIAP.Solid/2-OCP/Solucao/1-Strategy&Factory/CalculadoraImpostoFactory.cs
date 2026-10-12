using FIAP.Solid.OCP.Violacao;

namespace FIAP.Solid.OCP.Solucao.StrategyFactory;

public class CalculadoraImpostoFactory : ICalculadoraImpostoFactory
{
    private readonly IEnumerable<ICalculadoraImposto> _calculadoras;
    private readonly CalculadoraSemImposto _alternativa = new();

    public CalculadoraImpostoFactory(IEnumerable<ICalculadoraImposto> calculadoras)
    {
        _calculadoras = calculadoras;
    }

    public ICalculadoraImposto ObterInstanciaCalculadora(string codigoPais)
    {
        return _calculadoras.FirstOrDefault(c => c.PodeCalcular(codigoPais)) ?? _alternativa;
    }
}


public interface ICalculadoraImpostoFactory
{
    ICalculadoraImposto ObterInstanciaCalculadora(string codigoPais);
}
