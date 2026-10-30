namespace FIAP.Solid.ISP.Solucao;

public interface IUsuarioServico
{
    Task<Usuario?> ObterPorIdAsync(Guid id);
    Task CriarUsuarioAsync(CriarUsuarioRequisicao requisicao);
    Task AtualizarUsuarioAsync(Guid id, AtualizarUsuarioRequisicao requisicao);
    Task AtualizarSenhaAsync(Guid id, string novaSenha);
}
