using FIAP.Solid.LSP.PosCondicao.Solucao;

namespace FIAP.Solid._3_LSP.PosCondicao.Solucao;

public class CSVGeradorRelatorio : IGeradorRelatorioLocal
{
    public string Gerar()
    {
        // Lógica para gerar o relatório CSV

        // salvar o arquivo CSV

        // retornar o caminho do arquivo CSV gerado
        return $"/relatorios/relatorio_{Guid.NewGuid()}.csv";
    }
}
