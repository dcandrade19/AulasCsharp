using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Aluno
    {
        private string nome;
        private string cpf;
        private DateTime nascimento;

        public Aluno(string nome, string cpf, DateTime nascimento)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.nascimento = nascimento;
        }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public DateTime Nascimento { get; set; }
    }
}
