using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio4
{
    public class Eleicao
    {
        public string? Nome { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public ECargosEmDisputa Cargos { get; set; }
        public List<Candidato> Candidatos { get; set; }
        public List<Voto> Votos { get; set; }
        public List<string> VotosCsv { get; set; }

        public Eleicao(string nome, DateTime dataInicial, DateTime dataFinal)
        {
            Nome = nome;
            DataInicial = dataInicial;
            DataFinal = dataFinal;
        }
    }
}       