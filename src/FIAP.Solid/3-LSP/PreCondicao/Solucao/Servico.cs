namespace FIAP.Solid.LSP.PreCondicao.Solucao;

public class Servico
{
    public void RealizarDeposito(ContaBancaria conta, decimal valor)
    {
        conta.Depositar(valor);
    }
}
