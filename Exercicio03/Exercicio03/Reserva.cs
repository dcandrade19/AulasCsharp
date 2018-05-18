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

        public Reserva(DateTime dataReserva, Cliente cliente, IList<Carro> carros)
        {
            DataReserva = dataReserva;
            Cliente = cliente;
            Carros = carros;
        }
    }
}
