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
    }
}
