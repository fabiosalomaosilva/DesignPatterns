using DesignPatterns.Strategy.Models;
using DesignPatterns.Strategy.Services;

namespace DesignPatterns.Strategy.Contexts;

public class PagamentoContext : IPagamentoContext
{
    private IPagamentoStrategy? _pagamentoStrategy;

    public string ExecutarPagamento(MetodoPagamentoEnum metodoPagamento)
    {
        _pagamentoStrategy = metodoPagamento switch
        {
            MetodoPagamentoEnum.Credito => new CreditoStrategy(),
            MetodoPagamentoEnum.Debito => new DebitoStrategy(),
            MetodoPagamentoEnum.Boleto => new BoletoStrategy(),
            MetodoPagamentoEnum.Pix => new PixStrategy(),
            _ => new BoletoStrategy()
        };

        return _pagamentoStrategy.ProcessarPagamento();
    }
}