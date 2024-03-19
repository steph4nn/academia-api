using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AcademiaAPI.Models
{

    public class Pagamentos
    {
        [Column("id_pagamento")]
        public int Id{get;set;}
        
        [Column("aluno_cpf")]
        public string? Cpf {get;set;}
        
        [Column("data_pagamento")]
        public DateTime DataDePagamento {get;set;}
        
        [Column("planos_id")]
        public int planosId {get;set;}

        public Pagamentos()
        {

        }
        

        public Pagamentos(int id ,String cpf, DateTime dataDePagamento, int idPlano)
        {
            Id= id;
            Cpf= cpf;
            DataDePagamento = dataDePagamento.Date;
            planosId = idPlano;
        }
        public override string ToString()
        {
        return $"Id: {Id}, Cpf: {Cpf}, DataDePagamento: {DataDePagamento}, IdPlano: {planosId}";
        }
    }
}