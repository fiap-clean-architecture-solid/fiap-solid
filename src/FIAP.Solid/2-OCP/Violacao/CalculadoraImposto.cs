namespace FIAP.Solid.OCP.Violacao;

public class CalculadoraImposto
{
    public decimal CalcularImposto(Pedido pedido, Usuario usuario)
    {
        var subtotal = pedido.Itens.Sum(i => i.Quantidade * i.Produto.Preco);
        var total = subtotal + pedido.Entrega;

        var aliquota = usuario.CodigoPais switch
        {
            "BRA" => 0.17m,
            "AUS" => 0.10m,
            _     => 0.00m
        };

        return total * aliquota;
    }
}

#region Models
public class Pedido
{
    public List<ItemPedido> Itens { get; set; } = [];
    public decimal Entrega { get; set; }

    public decimal Imposto { get; set; }
}

public class ItemPedido
{
    public Produto Produto { get; set; } = new();
    public int Quantidade { get; set; }
}

public class Produto
{
    public string Nome { get; set; } = string.Empty;
    public decimal Preco { get; set; }
}

public class Usuario
{
    public string Nome { get; set; } = string.Empty;
    public string CodigoPais { get; set; } = string.Empty;
}
#endregion