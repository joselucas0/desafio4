using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio4
{
    public class Eleitor : Usuario
    {
        public string Senha { get; set; }

        public Eleitor(string nome, string id, string senha)
            : base(nome, id)
        {
            Senha = senha;
        }
    }
}