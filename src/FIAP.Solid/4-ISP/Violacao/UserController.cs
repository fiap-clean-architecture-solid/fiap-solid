namespace FIAP.Solid.ISP.Violacao;

public class UserController
{
    private readonly IUsuarioServico _usuarioServico;

    public UserController(IUsuarioServico usuarioServico)
    {
        _usuarioServico = usuarioServico;
    }

    public Task<Usuario?> ObterPerfilAsync(Guid id) =>
        _usuarioServico.ObterPorIdAsync(id);

    public Task CadastrarAsync(CriarUsuarioRequisicao requisicao) =>
        _usuarioServico.CriarUsuarioAsync(requisicao);

    public Task AtualizarPerfilAsync(Guid id, AtualizarUsuarioRequisicao requisicao) =>
        _usuarioServico.AtualizarUsuarioAsync(id, requisicao);

    public Task AlterarSenhaAsync(Guid id, string novaSenha) =>
        _usuarioServico.AtualizarSenhaAsync(id, novaSenha);
}
