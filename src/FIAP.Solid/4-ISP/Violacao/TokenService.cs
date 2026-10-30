namespace FIAP.Solid.ISP.Violacao;

public class TokenService
{
    private readonly IUsuarioServico _usuarioServico;

    public TokenService(IUsuarioServico usuarioServico)
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
