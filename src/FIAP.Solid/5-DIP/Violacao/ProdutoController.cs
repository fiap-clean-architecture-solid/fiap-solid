namespace FIAP.Solid.DIP.Violacao;

public class ProdutoController
{
    private readonly ProdutoServico _produtoServico;

    public ProdutoController()
    {
        _produtoServico = new ProdutoServico();
    }

    public Produto? ObterPorId(int id)
    {
        return _produtoServico.ObterPorId(id);
    }
}
