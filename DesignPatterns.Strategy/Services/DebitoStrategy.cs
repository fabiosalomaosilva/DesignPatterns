namespace DesignPatterns.Strategy.Services;

public class DebitoStrategy : IPagamentoStrategy
{
    public string ProcessarPagamento()
    {
        const string message = "Processando pagamento via Cartão de Débito";
        Console.WriteLine(message);
        return message;
    }
}