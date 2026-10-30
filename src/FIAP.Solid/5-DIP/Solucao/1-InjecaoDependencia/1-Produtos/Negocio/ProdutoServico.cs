namespace FIAP.Solid.DIP.Solucao;

public class ProdutoServico : IProdutoServico
{
    private readonly IProdutoRepositorio _repositorio;

    public ProdutoServico(IProdutoRepositorio repositorio)
    {
        _repositorio = repositorio;
    }

    public Produto? ObterPorId(int id)
    {
        return _repositorio.ObterPorId(id);
    }
}
