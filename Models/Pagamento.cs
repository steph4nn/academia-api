using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademiaAPI.Models
{
    public class Pagamento
    {
        public string? Cpf {get;set;}
        public DateTime DataDePagamento {get;set;}
        public int? IdPlano {get;set;}

        public Pagamento()
        {
        }

        public Pagamento(String cpf, DateTime dataDePagamento, int idPlano)
        {
            Cpf= cpf;
            DataDePagamento = dataDePagamento;
            IdPlano	 = idPlano;
        }
    }
}