using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Filial
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public IList<Carro> Carros { get; set; }
        public IList<Aluguel> Alugueis { get; set; }
    }
}
