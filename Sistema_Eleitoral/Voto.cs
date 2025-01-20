using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio4
{
    public class Voto
    {
        public string IdVoto { get; set; }
        public Candidato Candidato { get; set; }
        public DateTime HorarioDoVoto { get; set; }
        public Eleitor Eleitor { get; set; }

        public Voto(Candidato candidato, Eleitor eleitor)
        {
            this.Candidato = candidato;
            this.Eleitor = eleitor;
            this.IdVoto = Guid.NewGuid().ToString();
            this.HorarioDoVoto = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Voto: {IdVoto}, Candidato: {Candidato}, Eleitor: {Eleitor}, Hora do Voto: {HorarioDoVoto}";
        }
    }
}