using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademiaAPI.Models
{
    public class AlunoBuilder
    {
        private Aluno _aluno;

        public AlunoBuilder()
        {
            _aluno = new Aluno();
        }

        public AlunoBuilder WithCpf(string cpf)
        {
            _aluno.Cpf = cpf;
            return this;
        }

        public AlunoBuilder WithNome(string nome)
        {
            _aluno.Nome = nome;
            return this;
        }

        public AlunoBuilder WithDiaVencimento(int diaVencimento)
        {
            _aluno.DiaVencimento = diaVencimento;
            return this;
        }

        public AlunoBuilder WithDataIngresso(DateTime dataIngresso)
        {
            _aluno.DataIngresso = dataIngresso.Date;
            return this;
        }

        public AlunoBuilder WithTipo(int tipo)
        {
            _aluno.Tipo = tipo;
            return this;
        }

        public AlunoBuilder WithEndereco(Endereco endereco)
        {
            _aluno.Endereco = endereco;
            return this;
        }

        public AlunoBuilder WithContato(Contato contato)
        {
            _aluno.Contato = contato;
            return this;
        }

        public Aluno Build()
        {
            return _aluno;
        }
    }
}