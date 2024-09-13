using DesignPatterns.Strategy.Models;

namespace DesignPatterns.Strategy.Contexts;

public interface IPagamentoContext
{
    string ExecutarPagamento(MetodoPagamentoEnum metodoPagamento);
}