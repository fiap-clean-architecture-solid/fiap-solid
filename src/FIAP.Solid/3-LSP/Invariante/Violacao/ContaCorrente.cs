namespace FIAP.Solid.LSP.Invariante.Violacao;

public class ContaCorrente : ContaBancaria
{
    public decimal ChequeEspecial { get; private set; }

    public override void Sacar(decimal valor)
    {
        if (valor <= 0)
            throw new ArgumentException("O valor do saque deve ser maior que zero.");

        var saldoDisponivel = Saldo + ChequeEspecial;

        if (valor > saldoDisponivel)
            throw new InvalidOperationException("Saldo insuficiente para o saque.");

        Saldo -= valor;
    }
}