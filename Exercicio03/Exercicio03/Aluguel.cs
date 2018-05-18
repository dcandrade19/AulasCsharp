using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Aluguel
    {
        public DateTime DataAluguel { get; set; }
        public DateTime DataDevolucao { get; set; }
        public IList<Carro> Carros { get; set; }
        public Filial Filial { get; set; }
        public Pagamento Pagamento { get; set; }

        public Aluguel(DateTime dataAluguel, DateTime dataDevolucao, IList<Carro> carros, Filial filial, Pagamento pagamento)
        {
            DataAluguel = dataAluguel;
            DataDevolucao = dataDevolucao;
            Carros = carros;
            Filial = filial;
            Pagamento = pagamento;
        }
    }
}
