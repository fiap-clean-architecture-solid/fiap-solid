namespace FIAP.Solid.ISP.Violacao;

public class AdminController
{
    private readonly IUsuarioServico _usuarioServico;

    public AdminController(IUsuarioServico usuarioServico)
    {
        _usuarioServico = usuarioServico;
    }

    public Task<Usuario?> ConsultarUsuarioAsync(Guid id) =>
        _usuarioServico.ObterPorIdAsync(id);

    public Task CadastrarAdministradorAsync(CriarUsuarioAdministradorRequisicao requisicao) =>
        _usuarioServico.CriarUsuarioAdministradorAsync(requisicao);
}
