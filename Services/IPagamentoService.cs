using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcademiaAPI.Models;

namespace AcademiaAPI.Services
{
    public interface IPagamentoService
    {
        Task <bool> CreatePagamento(Pagamento pagamento);
        Task <List<Pagamento>> GetPagamentos();
        Task <Pagamento>GetPagamentoPorId(int id);
    }
}