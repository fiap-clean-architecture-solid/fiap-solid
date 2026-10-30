namespace FIAP.Solid.ISP.Violacao;

public interface IUsuarioServico
{
    Task<Usuario?> ObterPorIdAsync(Guid id);
    Task<Usuario?> ObterPorEmailAsync(string email);
    Task CriarUsuarioAsync(CriarUsuarioRequisicao requisicao);
    Task AtualizarUsuarioAsync(Guid id, AtualizarUsuarioRequisicao requisicao);
    Task AtualizarSenhaAsync(Guid id, string novaSenha);
    Task CriarUsuarioAdministradorAsync(CriarUsuarioAdministradorRequisicao requisicao);
    Task<bool> VerificarSenhaAsync(string email, string senha);
}
