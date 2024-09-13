using DesignPatterns.Strategy.Contexts;
using DesignPatterns.Strategy.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Strategy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PagamentosController(IPagamentoContext pagamentoContext) : ControllerBase
    {
        [HttpPost("pagar")]
        public IActionResult Pagar([FromQuery] MetodoPagamentoEnum metodoPagamento)
        {
            var result = pagamentoContext.ExecutarPagamento(metodoPagamento);

            return Ok(result);
        }
    }
}