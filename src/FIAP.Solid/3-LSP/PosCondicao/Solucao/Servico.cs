namespace FIAP.Solid.LSP.PosCondicao.Solucao;

public class Servico
{
    public void ProcessarRelatorio(IGeradorRelatorioLocal gerador)
    {
        var caminho = gerador.Gerar();


        if(!File.Exists(caminho))
        {
            throw new FileNotFoundException($"O arquivo gerado não foi encontrado: {caminho}");
        }

        // Lógica
    }

    public void ProcessarRelatorioCloud(IGeradorRelatorioCloud gerador)
    {
        var caminho = gerador.Gerar();        

        // Lógica
    }
}
