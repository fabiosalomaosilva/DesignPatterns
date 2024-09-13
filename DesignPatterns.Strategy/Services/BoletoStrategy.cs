namespace DesignPatterns.Strategy.Services;

public class BoletoStrategy : IPagamentoStrategy
{
    public string ProcessarPagamento()
    {
        const string message = "Processando pagamento via Boleto";
        Console.WriteLine(message);
        return message;
    }
}