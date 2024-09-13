namespace DesignPatterns.Strategy.Services;

public class PixStrategy : IPagamentoStrategy
{
    public string ProcessarPagamento()
    {
        const string message = "Processando pagamento via PIX";
        Console.WriteLine(message);
        return message;
    }
}