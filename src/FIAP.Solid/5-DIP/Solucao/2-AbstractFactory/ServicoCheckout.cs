namespace FIAP.Solid.DIP.Solucao;

public class ServicoCheckout
{
    private readonly ICalculadoraImpostoFactory _fabricaCalculadora;

    public ServicoCheckout(ICalculadoraImpostoFactory fabricaCalculadora)
    {
        _fabricaCalculadora = fabricaCalculadora;
    }

    public decimal CalcularImposto(decimal valor, string codigoPais)
    {
        var calculadora = _fabricaCalculadora.Criar(codigoPais);
        return calculadora.Calcular(valor);
    }
}
