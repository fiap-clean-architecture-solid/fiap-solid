namespace FIAP.Solid.LSP.PosCondicao.Violacao;

public class S3GeradorRelatorio : IGeradorRelatorio
{
    public string Gerar()
    {
        // Lógica para gerar o relatório

        // salvar o arquivo no AWS S3

        // retornar o caminho do arquivo no AWS S3 gerado
        return $"https://s3.amazonaws.com/bucket/relatorio_{Guid.NewGuid()}.pdf";
    }
}
