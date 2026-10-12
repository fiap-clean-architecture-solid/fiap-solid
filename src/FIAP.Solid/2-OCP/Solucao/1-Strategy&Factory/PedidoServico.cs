using FIAP.Solid.OCP.Violacao;

namespace FIAP.Solid.OCP.Solucao.StrategyFactory;

public class PedidoServico
{
    private readonly ICalculadoraImpostoFactory _fabricaCalculadoraImposto;
    private readonly IServicoUsuario _servicoUsuario;

    public PedidoServico(
        ICalculadoraImpostoFactory fabricaCalculadoraImposto,
        IServicoUsuario servicoUsuario)
    {
        _fabricaCalculadoraImposto = fabricaCalculadoraImposto;
        _servicoUsuario = servicoUsuario;
    }

    public async Task<Pedido> RealizarPedidoAsync(
        Pedido pedido,
        Guid idUsuario,
        CancellationToken ct)
    {
        var usuario = await _servicoUsuario.ObterUsuarioAsync(idUsuario, ct);

        var calculadora = _fabricaCalculadoraImposto.ObterInstanciaCalculadora(
            usuario.CodigoPais);

        pedido.Imposto = calculadora.CalcularImposto(pedido);

        return pedido;
    }
}


#region Interfaces

public interface IServicoUsuario
{
    Task<Usuario> ObterUsuarioAsync(Guid idUsuario, CancellationToken ct);
}

#endregion
