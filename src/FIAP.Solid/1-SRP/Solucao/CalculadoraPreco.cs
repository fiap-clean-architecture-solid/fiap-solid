namespace FIAP.Solid.SRP.Solucao;

public class CalculadoraPreco : ICalculadoraPreco
{
    private const decimal LimiteDesconto = 500m;
    private const decimal TaxaDesconto = 0.95m;

    public decimal Calcular(Pedido pedido)
    {
        decimal total = 0;
        foreach (var item in pedido.Itens)
            total += item.PrecoUnitario * item.Quantidade;

        if (total > LimiteDesconto)
            total *= TaxaDesconto;

        return total;
    }
}