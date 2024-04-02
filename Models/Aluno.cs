using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AcademiaAPI.Models
{
    public class Aluno
    {

        [Required]
        [MinLength(11)]
        public string Cpf {get; set;}

        [Required]
        [MaxLength(100)]
        public string Nome {get; set;}

        [Required]
        public int DiaVencimento {get;  set;}

        [Required]
        public DateTime DataIngresso{get; set;}

        [Required]
        public int Tipo{get;set;}

        [Required]
        public long NumeroContato {get;set;}
        
        [Required]
        [EmailAddress]
        public string EmailContato {get;set;}

        public string Rua {get; set;}
        public  int NumeroEndereco {get; set;}
        public string Bairro {get; set;}
        public string Cidade {get; set;}
        public string Estado {get; set;}

        [MinLength(8)]
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