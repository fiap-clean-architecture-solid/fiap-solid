namespace FIAP.Solid.ISP.Solucao;

public class UsuarioTokenServico : IUsuarioTokenServico
{
    private readonly IUsuarioRepositorio _repositorio;
    private readonly IPasswordService _passwordService;

    public UsuarioTokenServico(
        IUsuarioRepositorio repositorio,
        IPasswordService passwordService)
    {
        _repositorio = repositorio;
        _passwordService = passwordService;
    }

    public Task<Usuario?> ObterPorEmailAsync(string email) =>
        Task.FromResult(_repositorio.ObterPorEmail(email));

    public async Task<bool> VerificarSenhaAsync(string email, string senha)
    {
        var usuario = await ObterPorEmailAsync(email);
        return usuario is not null && _passwordService.Verificar(usuario.SenhaHash, senha);
    }
}
