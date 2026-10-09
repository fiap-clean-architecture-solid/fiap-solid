namespace FIAP.Solid.SRP.Solucao;

public class PedidoRepositorio : IPedidoRepositorio
{
    private readonly string _stringConexao;

    public PedidoRepositorio(string stringConexao)
    {
        _stringConexao = stringConexao;
    }

    public void Salvar(Pedido pedido)
    {
        using var conexao = new SqlConnection(_stringConexao);
        conexao.Open();

        var comando = new SqlCommand(
            "INSERT INTO Orders (CustomerEmail, Total) VALUES (@email, @total)",
            conexao);
        comando.Executar();
    }

}



#region Classes exemplo

public class SqlConnection(string stringConexao) : IDisposable
{
    private readonly string _stringConexao = stringConexao;

    public void Open()
    {
        Console.WriteLine($"Conectando ao banco de dados com a string: {_stringConexao}");
    }

    public void Dispose()
    {
        Console.WriteLine("Fechando conexão com o banco de dados.");
    }
}

public class SqlCommand(string commandText, SqlConnection connection)
{
    private readonly string _commandText = commandText;
    private readonly SqlConnection _connection = connection;

    public void Executar()
    {
        Console.WriteLine($"Executando comando SQL: {_commandText}");
    }
}

#endregion
