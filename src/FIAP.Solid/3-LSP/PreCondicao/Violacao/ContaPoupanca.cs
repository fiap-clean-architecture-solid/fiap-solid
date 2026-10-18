namespace FIAP.Solid.LSP.PreCondicao.Violacao;

public class ContaPoupanca : ContaBancaria
{
    public override void Depositar(decimal valor)
    {
        if (valor <= 10)
        {
            throw new ArgumentException("O valor do depósito deve ser maior que 10.", nameof(valor));
        }

        base.Depositar(valor);
    }
}