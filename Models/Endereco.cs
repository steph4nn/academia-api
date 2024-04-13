using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademiaAPI.Models
{
    public class Endereco
    {
        
        public string Cpf {get; set;}
        public string Rua {get; set;}
        public  int Numero {get; set;}
        public string Bairro {get; set;}
        public string Cidade {get; set;}
        public string Estado {get; set;}
        public string Cep {get; set;}

        public Endereco()
        {
        }
        public Endereco(string cpf,string rua, int numero, string bairro, string cidade, string estado, string cep)
        {
            Cpf = cpf;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
        }
    }
}