namespace FIAP.Solid.LSP.PreCondicao.Solucao;

public abstract class ContaBancaria
{
    public decimal Saldo { get; private set; }

    public abstract decimal ValorMinimoDeposito { get; }

    public void Depositar(decimal valor)
    {
        if (valor <= ValorMinimoDeposito)
        {
            throw new ArgumentException($"O valor do depósito deve ser maior que {ValorMinimoDeposito}.", nameof(valor));
        }

        Saldo += valor;
    }
}
