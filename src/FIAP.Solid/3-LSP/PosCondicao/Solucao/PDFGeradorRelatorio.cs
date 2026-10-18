namespace FIAP.Solid.LSP.PosCondicao.Solucao;

public class PDFGeradorRelatorio : IGeradorRelatorioLocal
{
    public string Gerar()
    {
        // Lógica para gerar o relatório PDF

        // salvar o arquivo PDF

        // retornar o caminho do arquivo PDF gerado
        return $"/relatorios/relatorio_{Guid.NewGuid()}.pdf";
    }
}
