using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Carro
    {
        public string Placa { get; set; }
        public string Nome { get; set; }
        public string Cor { get; set; }
        public string Tipo { get; set; }
        public IList<Reserva> Reservas { get; set; }
        public IList<Acessorios> Acessorios { get; set; }
        public IList<Aluguel> Alugueis { get; set; }
        public Filial Filial { get; set; }

        public Carro(string placa, string nome, string cor, string tipo, IList<Reserva> reservas, IList<Acessorios> acessorios, IList<Aluguel> alugueis, Filial filial)
        {
            Placa = placa;
            Nome = nome;
            Cor = cor;
            Tipo = tipo;
            Reservas = reservas;
            Acessorios = acessorios;
            Alugueis = alugueis;
            Filial = filial;
        }
    }
}
