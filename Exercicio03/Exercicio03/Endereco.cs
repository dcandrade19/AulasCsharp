using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Endereco
    {
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public Filial Filial { get; set; }

        public Endereco(string rua, string cidade, string estado, string cep, int numero, string complemento, Filial filial)
        {
            Rua = rua;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
            Numero = numero;
            Complemento = complemento;
            Filial = filial;
        }
    }
}
