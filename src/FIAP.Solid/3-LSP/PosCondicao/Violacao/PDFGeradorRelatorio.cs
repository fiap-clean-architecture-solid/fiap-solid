using FIAP.Solid.LSP.PosCondicao.Violacao;

namespace FIAP.Solid._3_LSP.PosCondicao.Violacao;

public class PDFGeradorRelatorio : IGeradorRelatorio
{
    public string Gerar()
    {
        // Lógica para gerar o relatório PDF

        // salvar o arquivo PDF

        // retornar o caminho do arquivo PDF gerado
        return $"/relatorios/relatorio_{Guid.NewGuid()}.pdf";
    }
}
