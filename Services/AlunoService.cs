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
            string sql = "INSERT INTO public.aluno (cpf, dia_vencimento, data_ingresso, nome, tipo) VALUES (@cpf, @diavencimento, @dataingresso, @nome, @tipo);INSERT INTO public.aluno_endereco(cpf, rua, numero, bairro, cidade, cep, estado)VALUES (@cpf, @rua, @numeroendereco, @bairro, @cidade, @cep, @estado);INSERT INTO public.aluno_contato(cpf,email, numero)VALUES ( @cpf, @email, @numerocontato); ";
            
            var result =
            await _dbService.EditData(sql, aluno);
        return true;
        }

        public async Task<bool> DeleteAluno(int id)
        {
            string sql ="DELETE FROM public.aluno WHERE id_aluno=@id";

            var DeleteAluno = await _dbService.EditData(sql, new { id });
            return true;
        }


        public async Task<List<Aluno>> GetAlunosList()
        {
            string sqlAluno = "SELECT * FROM public.Aluno";
            string sqlEndereco = "SELECT * FROM public.aluno_endereco";
            string sqlContato = "SELECT * FROM public.aluno_contato";

            var alunoListData = await _dbService.GetAll<Aluno>(sqlAluno, new { });
            var enderecoListData = await _dbService.GetAll<Endereco>(sqlEndereco, new { });
            var contatoListData = await _dbService.GetAll<Contato>(sqlContato, new { });

            var alunoList = new List<Aluno>();

            foreach (var alunoData in alunoListData)
                {
                    var endereco = enderecoListData.FirstOrDefault(e => e.Cpf == alunoData.Cpf);
                    var contato = contatoListData.FirstOrDefault(c => c.Cpf == alunoData.Cpf);

                    var aluno = new AlunoBuilder()
                        .WithCpf(alunoData.Cpf)
                        .WithNome(alunoData.Nome)
                        .WithEndereco(endereco)
                        .WithContato(contato)
                        .Build();

                    alunoList.Add(aluno);
                }

            return alunoList;
        }
        public async Task<Aluno> GetAluno(int id)
        {
            string sql = "SELECT * FROM public.aluno where id_aluno=@id";

            var aluno = await _dbService.GetAsync<Aluno>(sql, new {id});
            return aluno;
        }

        public async Task<Aluno> UpdateAluno(Aluno aluno)
        {
            string sql = "Update public.aluno SET  dia_vencimento=@diavencimento,  nome=@nome WHERE id_aluno=@id";

            var updateAluno =
            await _dbService.EditData(sql, aluno);
        return aluno;
        }
    }
}