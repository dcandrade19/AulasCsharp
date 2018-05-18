using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Pagamento
    {
        public double Valor { get; set; }
        public string Tipo { get; set; }
        public IList<Aluguel> Alugueis { get; set; }

        public Pagamento(double valor, string tipo, IList<Aluguel> alugueis)
        {
            Valor = valor;
            Tipo = tipo;
            Alugueis = alugueis;
        }
    }
}
