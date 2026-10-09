using Microsoft.Extensions.Logging;

namespace FIAP.Solid.SRP.Solucao;

public class PedidoServico
{
    private readonly IPedidoValidador _validador;
    private readonly ICalculadoraPreco _calculadoraPreco;
    private readonly IPedidoRepositorio _repositorio;
    private readonly IPedidoNotificador _notificador;
    private readonly ILogger<PedidoServico> _logger;

    public PedidoServico(
        IPedidoValidador validador,
        ICalculadoraPreco calculadoraPreco,
        IPedidoRepositorio repositorio,
        IPedidoNotificador notificador,
        ILogger<PedidoServico> logger)
    {
        _validador = validador;
        _calculadoraPreco = calculadoraPreco;
        _repositorio = repositorio;
        _notificador = notificador;
        _logger = logger;
    }

    public void RealizarPedido(Pedido pedido)
    {
        _validador.Validar(pedido);
        pedido.Total = _calculadoraPreco.Calcular(pedido);
        _repositorio.Salvar(pedido);
        _notificador.NotificarConfirmacao(pedido);

        _logger.LogInformation(
            "Pedido do cliente {Email} processado. Total: {Total:C}",
            pedido.Cliente.Email, pedido.Total);
    }
}



#region Models
public class Pedido
{
    public Cliente Cliente { get; set; } = new();
    public List<Item> Itens { get; set; } = new();
    public decimal Total { get; set; }
}

public class Item
{
    public string Nome { get; set; } = string.Empty;
    public decimal PrecoUnitario { get; set; }
    public int Quantidade { get; set; }
}

public class Cliente
{
    public string Email { get; set; } = string.Empty;
}
#endregion