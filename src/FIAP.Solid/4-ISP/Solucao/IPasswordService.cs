namespace FIAP.Solid.ISP.Solucao;

public interface IPasswordService
{
    string GerarHash(string senha);
    bool Verificar(string senhaHash, string senhaInformada);
}
