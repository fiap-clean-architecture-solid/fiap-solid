namespace FIAP.Solid.SRP.Solucao;

public class PedidoNotificadorEmail : IPedidoNotificador
{
    private readonly string _servidorSmtp;

    public PedidoNotificadorEmail(string servidorSmtp)
    {
        _servidorSmtp = servidorSmtp;
    }

    public void NotificarConfirmacao(Pedido pedido)
    {
        var cliente = new SmtpClient(_servidorSmtp);
        var mensagem = new MailMensagem(
            "no-reply@loja.com",
            pedido.Cliente.Email,
            "Pedido confirmado",
            $"Seu pedido foi confirmado. Total: {pedido.Total:C}");
        cliente.Enviar(mensagem);
    }
}


#region Classes exemplo

public class SmtpClient(string servidorSmtp)
{
    private readonly string _servidorSmtp = servidorSmtp;

    public void Enviar(MailMensagem mensagem)
    {
        Console.WriteLine($"Enviando e-mail para {mensagem.To} via {_servidorSmtp}");
        Console.WriteLine($"Assunto: {mensagem.Subject}");
        Console.WriteLine($"Corpo: {mensagem.Body}");
    }
}

public class MailMensagem(string from, string to, string subject, string body)
{
    public string From { get; } = from;
    public string To { get; } = to;
    public string Subject { get; } = subject;
    public string Body { get; } = body;
}

#endregion