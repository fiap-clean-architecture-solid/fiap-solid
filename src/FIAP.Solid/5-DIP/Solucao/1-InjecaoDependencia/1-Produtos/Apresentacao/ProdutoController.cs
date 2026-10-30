namespace FIAP.Solid.DIP.Solucao;

public class ProdutoController
{
    private readonly IProdutoServico _produtoServico;

    public ProdutoController(IProdutoServico produtoServico)
    {
        _produtoServico = produtoServico;
    }

    public Produto? ObterPorId(int id)
    {
        return _produtoServico.ObterPorId(id);
    }
}
