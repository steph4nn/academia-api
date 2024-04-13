using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademiaAPI.Models
{
    public class Contato

    {

        public string Cpf {get;set;}
        public long Numero {get;set;}
        
        public string Email {get;set;}

        public Contato()
        {
        }
        public Contato(string cpf,long numeroContato, string email)
        {
            Cpf = cpf;
            Numero = numeroContato;
            Email = email;
        }
    }
}