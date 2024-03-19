using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcademiaAPI.Models;

namespace AcademiaAPI.Services
{
    public interface IPagamentoService
    {
        Task <bool> CreatePagamento(Pagamentos pagamento);
        Task <List<Pagamentos>> GetPagamentos();
        Task <Pagamentos>GetPagamentoPorId(int id);
    }
}