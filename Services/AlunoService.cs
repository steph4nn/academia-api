using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcademiaAPI.Models;

namespace AcademiaAPI.Services
{
    public class AlunoService :IAlunoService
    {
        private readonly IDbService _dbService;
        public AlunoService(IDbService dbService)
    {
        _dbService = dbService;
    }

        public async Task<bool> CreateAluno(Aluno aluno)
        {
             var result =
            await _dbService.EditData(
                "INSERT INTO public.aluno (cpf, data_vencimento, data_ingresso, nome) VALUES (@cpf, @datavencimento, @dataingresso, @nome)",
                aluno);
        return true;
        }

        public async Task<bool> DeleteAluno(int id)
        {
            var DeleteAluno = await _dbService.EditData("DELETE FROM public.aluno WHERE id_aluno=@id", new { id });
            return true;
        }


        public async Task<List<Aluno>> GetAlunosList()
        {
            var alunoList = await _dbService.GetAll<Aluno>("SELECT * FROM public.aluno", new { });
            return alunoList;
        }
        public async Task<Aluno> GetAluno(int id)
        {
            var alunoList = await _dbService.GetAsync<Aluno>("SELECT * FROM public.aluno where id_aluno=@id", new {id});
            return alunoList;
        }

        public async Task<Aluno> UpdateAluno(Aluno aluno)
        {
            var updateAluno =
            await _dbService.EditData(
                "Update public.aluno SET  data_vencimento=@datavencimento,  nome=@nome WHERE id_aluno=@id",
                aluno);
        return aluno;
        }
    }
}