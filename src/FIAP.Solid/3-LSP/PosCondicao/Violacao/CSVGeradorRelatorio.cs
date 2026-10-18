namespace FIAP.Solid.LSP.PosCondicao.Violacao;

public class CSVGeradorRelatorio : IGeradorRelatorio
{
    public string Gerar()
    {
        // Lógica para gerar o relatório CSV

        // salvar o arquivo CSV

        // retornar o caminho do arquivo CSV gerado
        return $"/relatorios/relatorio_{Guid.NewGuid()}.csv";
    }
}
