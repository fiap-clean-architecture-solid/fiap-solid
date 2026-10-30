namespace FIAP.Solid.DIP.Solucao;

public interface ICalculadoraImposto
{
    decimal Calcular(decimal valor);
}

public class CalculadoraImpostoBrasil : ICalculadoraImposto
{
    public decimal Calcular(decimal valor)
    {
        return valor * 0.1m;
    }
}

public class CalculadoraImpostoArgentina : ICalculadoraImposto
{
    public decimal Calcular(decimal valor)
    {
        return valor * 0.21m;
    }
}
