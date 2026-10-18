namespace FIAP.Solid.LSP.PreCondicao.Solucao;

public class ContaCorrente : ContaBancaria
{
    public override decimal ValorMinimoDeposito => 1;
}
