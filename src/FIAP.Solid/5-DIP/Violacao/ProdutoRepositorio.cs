namespace FIAP.Solid.DIP.Violacao;

public class ProdutoRepositorio
{
    public Produto? ObterPorId(int id)
    {
        return new Produto
        {
            Id = id,
            Nome = "Produto de exemplo",
            Preco = 100
        };
    }
}
