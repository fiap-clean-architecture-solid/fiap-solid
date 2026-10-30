namespace FIAP.Solid.LSP.PreCondicao.Violacao;

public class Servico
{
    public void RealizarDeposito(decimal valor)
    {
        //var conta = new ContaBancaria();
        ContaBancaria conta = new ContaPoupanca();

        conta.Depositar(valor);
    }
}
