using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Cliente
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public int Cpf { get; set; }
        public string Profissao { get; set; }
        public int Telefone { get; set; }
        public IList<Reserva> Reservas { get; set; }

        public Cliente(string nome, Endereco endereco, int cpf, string profissao, int telefone, IList<Reserva> reservas)
        {
            Nome = nome;
            Endereco = endereco;
            Cpf = cpf;
            Profissao = profissao;
            Telefone = telefone;
            Reservas = reservas;
        }
    }
}
