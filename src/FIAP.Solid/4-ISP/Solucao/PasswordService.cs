using System.Security.Cryptography;
using System.Text;

namespace FIAP.Solid.ISP.Solucao;

public class PasswordService : IPasswordService
{
    public string GerarHash(string senha)
    {
        var bytes = SHA256.HashData(Encoding.UTF8.GetBytes(senha));
        return Convert.ToHexString(bytes);
    }

    public bool Verificar(string senhaHash, string senhaInformada) =>
        senhaHash == GerarHash(senhaInformada);
}
