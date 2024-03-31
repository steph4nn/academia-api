using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using AcademiaAPI.Models;
using Dapper;
using System.Data;
using System.Linq;

namespace AcademiaAPI.Services
{
    public class PagamentoService : IPagamentoService
    {
        private readonly IDbService _dbService;

        public PagamentoService(IDbService dbService)
        {
            _dbService = dbService;
        }

        public async Task<bool> CreatePagamento(Pagamentos pagamento)
        {            
            string sql = "INSERT INTO public.pagamentos (id_pagamento, aluno_cpf, data_pagamento, planos_id) VALUES (@Id, @Cpf, @DataDePagamento, @PlanosId)";

            var result = await _dbService.EditData(sql, pagamento);
            return true;
        }
        public async Task<List<Pagamentos>> GetPagamentos()
        {
            string sql = "SELECT id_pagamento AS Id, aluno_cpf AS Cpf, data_pagamento AS DataDePagamento, planos_id AS planosId FROM public.pagamentos";

            var pagamentos = await _dbService.GetAll<Pagamentos>(sql, new { } );
            return (List<Pagamentos>)pagamentos;
        }
        
        public async Task<Pagamentos> GetPagamentoPorId(int id)
        {
            string sql = "SELECT id_pagamento AS Id, aluno_cpf AS Cpf, data_pagamento AS DataDePagamento, planos_id AS planosId FROM public.pagamentos where id_pagamento= @id";

            var pagamento = await _dbService.GetAsync<Pagamentos>(sql, new { Id = id});
            Console.WriteLine(pagamento);

            return pagamento;   

        }
    
    }
}
