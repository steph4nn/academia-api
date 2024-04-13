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

        public Endereco Endereco {get; set;}
        public Contato Contato {get; set;}


        public Aluno()
        {            
        }
        public Aluno(string cpf, string nome, int diaVencimento, int tipo, DateTime dataIngresso, Endereco endereco, Contato contato)
        {
            Cpf = cpf;
            Nome = nome;
            DiaVencimento = diaVencimento;
            Tipo = tipo;
            DataIngresso = dataIngresso.Date;
            Endereco = endereco;
            Contato = contato;
        }
    }
}