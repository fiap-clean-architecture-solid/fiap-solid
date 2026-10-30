namespace FIAP.Solid.ISP.Solucao;

public interface IUsuarioAdministradorServico
{
    Task<Usuario?> ObterPorIdAsync(Guid id);
    Task CriarUsuarioAdministradorAsync(CriarUsuarioAdministradorRequisicao requisicao);
}
