namespace FIAP.Solid.ISP.Solucao;

public class UsuarioAdministradorServico : IUsuarioAdministradorServico
{
    private readonly IUsuarioRepositorio _repositorio;
    private readonly IPasswordService _passwordService;

    public UsuarioAdministradorServico(
        IUsuarioRepositorio repositorio,
        IPasswordService passwordService)
    {
        _repositorio = repositorio;
        _passwordService = passwordService;
    }

    public Task<Usuario?> ObterPorIdAsync(Guid id) =>
        Task.FromResult(_repositorio.ObterPorId(id));

    public Task CriarUsuarioAdministradorAsync(CriarUsuarioAdministradorRequisicao requisicao)
    {
        var usuario = new Usuario(
            Guid.NewGuid(),
            requisicao.Nome,
            requisicao.Email,
            _passwordService.GerarHash(requisicao.Senha),
            true);

        _repositorio.Adicionar(usuario);
        return Task.CompletedTask;
    }
}
