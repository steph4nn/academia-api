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
        public int? DiaVencimento {get;  set;}
        public DateTime DataIngresso{get; set;}
        public int? Tipo{get;set;}

        public int? NumeroContato {get;set;}
        public string? EmailContato {get;set;}

        public string Rua {get; set;}
        public  int NumeroEndereco {get; set;}
        public string Bairro {get; set;}
        public string Cidade {get; set;}
        public string Estado {get; set;}
        public string Cep {get; set;}



        public Aluno()
        {            
        }
        public Aluno(string cpf, string nome, int diaVencimento, int tipo, DateTime dataIngresso, int numeroContato, string emailContato, string rua, int numero, string bairro, string cidade, string estado, string cep)
        {
            Cpf = cpf;
            DataIngresso = dataIngresso.Date;
            DiaVencimento = diaVencimento;
            Nome = nome;
            Tipo = tipo;
            NumeroContato = numeroContato;
            EmailContato = emailContato;
            Rua = rua;
            NumeroEndereco = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
        }
    }
}