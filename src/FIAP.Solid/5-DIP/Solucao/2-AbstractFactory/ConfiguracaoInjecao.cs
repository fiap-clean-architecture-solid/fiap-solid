using Microsoft.Extensions.DependencyInjection;

namespace FIAP.Solid.DIP.Solucao.AbstractFactory;

public static class ConfiguracaoInjecao
{
    public static IServiceCollection AdicionarDependencias(
        this IServiceCollection servicos)
    {

        servicos.AddTransient<CalculadoraImpostoBrasil>();
        servicos.AddTransient<CalculadoraImpostoArgentina>();

        return servicos;
    }
}
