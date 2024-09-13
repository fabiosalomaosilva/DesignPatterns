namespace DesignPatterns.Strategy.Services;

public class CreditoStrategy : IPagamentoStrategy
{
    public string ProcessarPagamento()
    {
        const string message = "Processando pagamento via Cartão de crédito";
        Console.WriteLine(message);
        return message;
    }
}