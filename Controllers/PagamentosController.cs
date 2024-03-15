using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AcademiaAPI.Models;
using AcademiaAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AcademiaAPI.Controllers
{
    [Route("[controller]")]
    public class PagamentosController : Controller
    {
        private readonly IPagamentoService _pagamentoService;

        [HttpPost]
        public async Task<IActionResult> CreatePagamento ([FromBody]Pagamento pagamento){
            
            var result = await _pagamentoService.CreatePagamento(pagamento);
            return Ok(result);
        }

        public async Task<IActionResult> GetAllPagamentos(){
            var result = await _pagamentoService.GetPagamentos();
            return Ok(result);

        } 

        public async Task<IActionResult>GetPagamentoPorId(int id){
            var result = await _pagamentoService.GetPagamentoPorId(id);
            return Ok(result);
        }

    }
}