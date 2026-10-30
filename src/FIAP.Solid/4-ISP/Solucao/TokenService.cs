namespace FIAP.Solid.ISP.Solucao;

public class TokenService
{
    private readonly IUsuarioTokenServico _usuarioServico;

    public TokenService(IUsuarioTokenServico usuarioServico)
    {
        _usuarioServico = usuarioServico;
    }

    public async Task<string?> GerarTokenAsync(string email, string senha)
    {
        if (!await _usuarioServico.VerificarSenhaAsync(email, senha))
        {
            return null;
        }

        return $"token-{email}";
    }
}
