namespace FIAP.Solid.DIP.Violacao;

public class ProdutoServico
{
    private readonly ProdutoRepositorio _repositorio;

    public ProdutoServico()
    {
        _repositorio = new ProdutoRepositorio();
    }

    public Produto? ObterPorId(int id)
    {
        return _repositorio.ObterPorId(id);
    }
}
