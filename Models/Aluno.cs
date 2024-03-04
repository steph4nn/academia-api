using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademiaAPI.Models
{
    public class Aluno
    {
        public string? Cpf {get; set;}
        public string? Nome {get; set;}
        public DateTime DataVencimento {get;  set;}
        public DateTime DataIngresso{get; set;}

        public Aluno()
        {            
        }
        public Aluno(string cpf, string nome, DateTime dataVencimento, DateTime dataIngresso)
        {
            this.Cpf = cpf;
            this.DataIngresso = dataIngresso;
            this.DataVencimento = dataVencimento;
            this.Nome = nome;
        }
    }
}