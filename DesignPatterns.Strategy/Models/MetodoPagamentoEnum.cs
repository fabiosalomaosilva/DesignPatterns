using System.ComponentModel;

namespace DesignPatterns.Strategy.Models
{
    public enum MetodoPagamentoEnum
    {
        [Description("Cartão de Crédito")] Credito = 1,
        [Description("Cartão de Débito")] Debito = 2,
        [Description("PIX")] Pix = 3,
        [Description("Boleto")] Boleto = 4
    }
}