namespace FIAP.Solid.ISP.Solucao;

public interface IUsuarioRepositorio
{
    Usuario? ObterPorId(Guid id);
    Usuario? ObterPorEmail(string email);
    void Adicionar(Usuario usuario);
    void Atualizar(Usuario usuario);
}

public class UsuarioRepositorio : IUsuarioRepositorio
{
    private readonly Dictionary<Guid, Usuario> _usuarios = [];

    public Usuario? ObterPorId(Guid id) =>
        _usuarios.GetValueOrDefault(id);

    public Usuario? ObterPorEmail(string email) =>
        _usuarios.Values.FirstOrDefault(
            usuario => usuario.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

    public void Adicionar(Usuario usuario) =>
        _usuarios.Add(usuario.Id, usuario);

    public void Atualizar(Usuario usuario) =>
        _usuarios[usuario.Id] = usuario;
}
