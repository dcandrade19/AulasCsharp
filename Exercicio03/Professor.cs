using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Professor
    {
        private string nome;
        private string cpf;
        private DateTime nascimento;
        private IList<Disciplina> disciplinas;

        public Professor(string nome, string cpf, DateTime nascimento, IList<Disciplina> disciplinas)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.nascimento = nascimento;
            this.disciplinas = disciplinas;
        }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public DateTime Nascimento { get; set; }

        public IList<Disciplina> Disciplinas { get; set; }
    }
}
