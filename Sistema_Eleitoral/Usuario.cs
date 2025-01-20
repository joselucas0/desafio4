using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio4
{
    public class Usuario
    {
        string Nome { get; set; }
        string Id { get; set; }
        string Cargo { get; set; }

        public Usuario(string nome, string cargo)
        {
            Nome = nome;
            Id = Guid.NewGuid().ToString();
            Cargo = cargo;
        }
    }
}