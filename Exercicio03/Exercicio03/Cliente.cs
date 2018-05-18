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
    }
}
