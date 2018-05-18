using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Reserva
    {
        public DateTime DataReserva { get; set; }
        public Cliente Cliente { get; set; }
        public IList<Carro> Carros { get; set; }
    }
}
