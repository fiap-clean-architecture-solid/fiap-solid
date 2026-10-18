namespace FIAP.Solid.LSP.PreCondicao.Solucao;

public class ContaPoupanca : ContaBancaria
{
    public override decimal ValorMinimoDeposito => 10;
}
