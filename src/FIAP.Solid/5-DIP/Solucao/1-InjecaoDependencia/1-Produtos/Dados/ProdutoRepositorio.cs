namespace FIAP.Solid.DIP.Solucao;

public class ProdutoRepositorio : IProdutoRepositorio
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
