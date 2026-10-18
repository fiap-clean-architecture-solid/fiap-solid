namespace FIAP.Solid.LSP.PreCondicao.Violacao;

public class Servico
{
    public void RealizarDeposito(decimal valor)
    {
        //var conta = new ContaBancaria();
        var conta = new ContaPoupanca();

        conta.Depositar(valor);
    }
}
