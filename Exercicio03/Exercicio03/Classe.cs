using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Classe
    {
        private string localizacao;

        public Classe(string localizacao)
        {
            this.localizacao = localizacao;
        }

        public string Localizacao { get; set; }
    }
}
