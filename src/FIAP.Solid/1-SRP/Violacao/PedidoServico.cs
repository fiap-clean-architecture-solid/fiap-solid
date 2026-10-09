using FIAP.Solid.SRP.Solucao;

namespace FIAP.Solid.SRP.Violacao;

public class PedidoServico
{
    private readonly string _stringConexao;
    private readonly string _servidorSmtp;

    public PedidoServico(string stringConexao, string servidorSmtp)
    {
        _stringConexao = stringConexao;
        _servidorSmtp = servidorSmtp;
    }

    public void RealizarPedido(Pedido pedido)
    {
        // Validação
        if (pedido.Itens == null || pedido.Itens.Count == 0)
            throw new InvalidOperationException("Pedido sem itens.");

        if (pedido.Cliente == null || string.IsNullOrWhiteSpace(pedido.Cliente.Email))
            throw new InvalidOperationException("Cliente inválido.");

        // Cálculo do total
        decimal total = 0;
        foreach (var item in pedido.Itens)
            total += item.PrecoUnitario * item.Quantidade;

        if (total > 500)
            total *= 0.95m; // 5% de desconto acima de 500

        pedido.Total = total;

        // Persistência
        using (var conexao = new SqlConnection(_stringConexao))
        {
            conexao.Open();
            var comando = new SqlCommand(
                "INSERT INTO Orders (CustomerEmail, Total) VALUES (@email, @total)",
                conexao);
            comando.Executar();
        }

        // Envio de e-mail de confirmação
        var cliente = new SmtpClient(_servidorSmtp);
        
            var mensagem = new MailMensagem(
                "no-reply@loja.com",
                pedido.Cliente.Email,
                "Pedido confirmado",
                $"Seu pedido foi confirmado. Total: {pedido.Total:C}");
            cliente.Enviar(mensagem);
        

        // Registro de log
        Console.WriteLine($"[{DateTime.Now}] Pedido do cliente {pedido.Cliente.Email} processado. Total: {pedido.Total:C}");
    }
}
