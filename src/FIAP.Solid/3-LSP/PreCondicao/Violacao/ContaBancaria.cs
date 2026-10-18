namespace FIAP.Solid.LSP.PreCondicao.Violacao;

public class ContaBancaria
{
    private decimal Saldo { get; set; }

    public virtual void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("O valor do depósito deve ser maior que zero.", nameof(valor));
        }

        Saldo += valor;
    }
}