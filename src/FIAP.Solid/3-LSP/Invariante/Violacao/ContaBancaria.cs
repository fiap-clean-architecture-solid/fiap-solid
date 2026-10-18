namespace FIAP.Solid.LSP.Invariante.Violacao;

public class ContaBancaria
{
    public decimal Saldo { get; set; }

    public virtual void Sacar(decimal valor)
    {
        if (valor <= 0)
            throw new ArgumentException("O valor do saque deve ser maior que zero.");

        if (valor > Saldo)
            throw new InvalidOperationException("Saldo insuficiente para o saque.");

        Saldo -= valor;
    }
}