using DesignPatterns.Strategy.Models;

namespace DesignPatterns.Strategy.ServicesSemPadrao
{
    public class PagamentoService
    {
        public void ProcessarPagamento(MetodoPagamentoEnum metodoPagamento)
        {
            if (metodoPagamento == MetodoPagamentoEnum.Credito)
            {
                Console.WriteLine("Processando pagamento via Cartão de Crédito");
            }
            else if (metodoPagamento == MetodoPagamentoEnum.Debito)
            {
                Console.WriteLine("Processando pagamento via Cartão de Débito");
            }
            else if (metodoPagamento == MetodoPagamentoEnum.Pix)
            {
                Console.WriteLine("Processando pagamento via PIX");
            }
            else if (metodoPagamento == MetodoPagamentoEnum.Boleto)
            {
                Console.WriteLine("Processando pagamento via Boleto");
            }
            else
            {
                throw new InvalidOperationException("Método de pagamento inválido");
            }
        }
    }
}