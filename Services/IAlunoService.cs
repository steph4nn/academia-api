using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcademiaAPI.Models;

namespace AcademiaAPI.Services
{
    public interface IAlunoService
    {
        Task<bool>CreateAluno(Aluno aluno);
        Task<List<Aluno>> GetAlunosList();
        Task<Aluno>GetAluno(int id);
        Task<Aluno> UpdateAluno(Aluno aluno);
        Task <bool> DeleteAluno(int id);
    }
}