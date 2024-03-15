using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcademiaAPI.Models;

namespace AcademiaAPI.Services
{
    public class PagamentoService : IPagamentoService
    {
        private readonly IDbService _dbService;
        public PagamentoService(IDbService dbService)
        {
            _dbService = dbService;
        }
            public async Task<bool> CreatePagamento(Pagamento pagamento)
        {            
            var result = await _dbService.EditData(
                "INSERT INTO public.pagamentos ( aluno_cpf, data_pagamento, planos_id) VALUES (@Cpf, @DataDePagamento, @PlanosId)",
                pagamento);
            return true;
        }

        public async Task<Pagamento> GetPagamentoPorId(int id)
        {
            var pagamento = await _dbService.GetAsync<Pagamento>("SELECT * FROM public.pagamentos where id_pagamento=@id", new {id});
            return pagamento;
        }

        public async Task<List<Pagamento>> GetPagamentos()
        {
            var pagamentoList = await _dbService.GetAll<Pagamento>("SELECT * FROM public.pagamentos", new { });
            return pagamentoList;
        }
    }
}