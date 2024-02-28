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
                "INSERT INTO public.aluno (cpf, data_vencimento, data_egresso, nome) VALUES (@cpf, @datavencimento, @dataegresso, @nome)",
                aluno);
        return true;
        }

        public async Task<bool> DeleteAluno(string cpf)
        {
            var DeleteAluno = await _dbService.EditData("DELETE FROM public.aluno WHERE cpf=@cpf", new { cpf });
            return true;
        }


        public async Task<List<Aluno>> GetAlunosList()
        {
            var alunoList = await _dbService.GetAll<Aluno>("SELECT * FROM public.aluno", new { });
            return alunoList;
        }
        public async Task<Aluno> GetAluno(string cpf)
        {
            var alunoList = await _dbService.GetAsync<Aluno>("SELECT * FROM public.aluno where cpf=@cpf", new {cpf});
            return alunoList;
        }

        public async Task<Aluno> UpdateAluno(Aluno aluno)
        {
            var updateAluno =
            await _dbService.EditData(
                "Update public.aluno SET  data_vencimento=@datavencimento,  nome=@nome WHERE cpf=@cpf",
                aluno);
        return aluno;
        }
    }
}