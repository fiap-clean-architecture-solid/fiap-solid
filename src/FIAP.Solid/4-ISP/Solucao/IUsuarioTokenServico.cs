namespace FIAP.Solid.ISP.Solucao;

public interface IUsuarioTokenServico
{
    Task<Usuario?> ObterPorEmailAsync(string email);
    Task<bool> VerificarSenhaAsync(string email, string senha);
}
