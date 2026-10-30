namespace FIAP.Solid.ISP.Violacao;

public class UsuarioServico : IUsuarioServico
{
    private readonly Dictionary<Guid, Usuario> _usuarios = [];

    public Task<Usuario?> ObterPorIdAsync(Guid id)
    {
        _usuarios.TryGetValue(id, out var usuario);
        return Task.FromResult(usuario);
    }

    public Task<Usuario?> ObterPorEmailAsync(string email)
    {
        var usuario = _usuarios.Values.FirstOrDefault(
            item => item.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

        return Task.FromResult(usuario);
    }

    public Task CriarUsuarioAsync(CriarUsuarioRequisicao requisicao)
    {
        var usuario = new Usuario(Guid.NewGuid(), requisicao.Nome, requisicao.Email, requisicao.Senha, false);
        _usuarios.Add(usuario.Id, usuario);
        return Task.CompletedTask;
    }

    public Task AtualizarUsuarioAsync(Guid id, AtualizarUsuarioRequisicao requisicao)
    {
        if (!_usuarios.TryGetValue(id, out var usuario))
        {
            throw new KeyNotFoundException($"Usuário não encontrado: {id}");
        }

        _usuarios[id] = usuario with { Nome = requisicao.Nome };
        return Task.CompletedTask;
    }

    public Task AtualizarSenhaAsync(Guid id, string novaSenha)
    {
        if (!_usuarios.TryGetValue(id, out var usuario))
        {
            throw new KeyNotFoundException($"Usuário não encontrado: {id}");
        }

        _usuarios[id] = usuario with { Senha = novaSenha };
        return Task.CompletedTask;
    }

    public Task CriarUsuarioAdministradorAsync(CriarUsuarioAdministradorRequisicao requisicao)
    {
        var usuario = new Usuario(Guid.NewGuid(), requisicao.Nome, requisicao.Email, requisicao.Senha, true);
        _usuarios.Add(usuario.Id, usuario);
        return Task.CompletedTask;
    }

    public async Task<bool> VerificarSenhaAsync(string email, string senha)
    {
        var usuario = await ObterPorEmailAsync(email);
        return usuario is not null && usuario.Senha == senha;
    }
}

public sealed record Usuario(Guid Id, string Nome, string Email, string Senha, bool EhAdministrador);

public sealed record CriarUsuarioRequisicao(string Nome, string Email, string Senha);

public sealed record AtualizarUsuarioRequisicao(string Nome);

public sealed record CriarUsuarioAdministradorRequisicao(string Nome, string Email, string Senha);
