using Microsoft.Extensions.DependencyInjection;

namespace FIAP.Solid.DIP.Solucao;

public static class ConfiguracaoInjecao
{
    public static IServiceCollection AdicionarDependenciasDIP(
        this IServiceCollection servicos)
    {
        servicos.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
        servicos.AddScoped<IProdutoServico, ProdutoServico>();
        servicos.AddScoped<ICalculadoraImpostoFactory, CalculadoraImpostoFactory>();

        return servicos;
    }
}
