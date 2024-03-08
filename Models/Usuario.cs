using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademiaAPI.Models
{
    public class Usuario
    {
        public string? NomeDeUsuario {get;set;}
        public string? Senha {get;set;}

        public Usuario(){}
        public Usuario(string nomeDeUsuario, string senha)
        {
            NomeDeUsuario = nomeDeUsuario;
            Senha = senha;
        }
    }
}