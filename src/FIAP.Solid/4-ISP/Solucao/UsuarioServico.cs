namespace FIAP.Solid.ISP.Solucao;

public class UsuarioServico : IUsuarioServico
{
    private readonly IUsuarioRepositorio _repositorio;
    private readonly IPasswordService _passwordService;

    public UsuarioServico(IUsuarioRepositorio repositorio, IPasswordService passwordService)
    {
        _repositorio = repositorio;
        _passwordService = passwordService;
    }

    public Task<Usuario?> ObterPorIdAsync(Guid id) =>
        Task.FromResult(_repositorio.ObterPorId(id));

    public Task CriarUsuarioAsync(CriarUsuarioRequisicao requisicao)
    {
        var usuario = new Usuario(
            Guid.NewGuid(),
            requisicao.Nome,
            requisicao.Email,
            _passwordService.GerarHash(requisicao.Senha),
            false);

        _repositorio.Adicionar(usuario);
        return Task.CompletedTask;
    }

    public Task AtualizarUsuarioAsync(Guid id, AtualizarUsuarioRequisicao requisicao)
    {
        var usuario = ObterUsuario(id);
        _repositorio.Atualizar(usuario with { Nome = requisicao.Nome });
        return Task.CompletedTask;
    }

    public Task AtualizarSenhaAsync(Guid id, string novaSenha)
    {
        var usuario = ObterUsuario(id);
        _repositorio.Atualizar(usuario with { SenhaHash = _passwordService.GerarHash(novaSenha) });
        return Task.CompletedTask;
    }

    private Usuario ObterUsuario(Guid id) =>
        _repositorio.ObterPorId(id)
        ?? throw new KeyNotFoundException($"Usuário não encontrado: {id}");
}

#region Modelos

public sealed record Usuario(
    Guid Id,
    string Nome,
    string Email,
    string SenhaHash,
    bool EhAdministrador);

public sealed record CriarUsuarioRequisicao(
    string Nome,
    string Email,
    string Senha);

public sealed record AtualizarUsuarioRequisicao(string Nome);

public sealed record CriarUsuarioAdministradorRequisicao(
    string Nome,
    string Email,
    string Senha);

#endregion
