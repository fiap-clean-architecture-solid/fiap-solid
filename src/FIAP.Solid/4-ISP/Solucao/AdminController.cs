namespace FIAP.Solid.ISP.Solucao;

public class AdminController
{
    private readonly IUsuarioAdministradorServico _usuarioServico;

    public AdminController(IUsuarioAdministradorServico usuarioServico)
    {
        _usuarioServico = usuarioServico;
    }

    public Task<Usuario?> ConsultarUsuarioAsync(Guid id) =>
        _usuarioServico.ObterPorIdAsync(id);

    public Task CadastrarAdministradorAsync(CriarUsuarioAdministradorRequisicao requisicao) =>
        _usuarioServico.CriarUsuarioAdministradorAsync(requisicao);
}
