using Microsoft.Extensions.DependencyInjection;

namespace FIAP.Solid.DIP.Solucao;

public interface ICalculadoraImpostoFactory
{
    ICalculadoraImposto Criar(string codigoPais);
}

public class CalculadoraImpostoFactory : ICalculadoraImpostoFactory
{
    private readonly IServiceProvider _provedorServicos;

    public CalculadoraImpostoFactory(IServiceProvider provedorServicos)
    {
        _provedorServicos = provedorServicos;
    }

    public ICalculadoraImposto Criar(string codigoPais)
    {
        return codigoPais.ToUpperInvariant() switch
        {
            "BR" => _provedorServicos.GetRequiredService<CalculadoraImpostoBrasil>(),
            "AR" => _provedorServicos.GetRequiredService<CalculadoraImpostoArgentina>(),
            _ => throw new ArgumentException(
                $"O país '{codigoPais}' não possui uma calculadora cadastrada.",
                nameof(codigoPais))
        };
    }
}
