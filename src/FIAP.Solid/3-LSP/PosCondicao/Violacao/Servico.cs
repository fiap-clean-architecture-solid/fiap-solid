namespace FIAP.Solid.LSP.PosCondicao.Violacao;

public class Servico
{
    public void ProcessarRelatorio(IGeradorRelatorio gerador)
    {
        var caminho = gerador.Gerar();

        if(!File.Exists(caminho))
        {
            throw new FileNotFoundException($"O arquivo gerado não foi encontrado: {caminho}");
        }

        // Lógica
    }
}
