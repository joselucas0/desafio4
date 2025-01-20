using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio4
{
    public interface IPersistencia
    {
        public void SalvarVotosEncriptados(string password);
        public void CarregarResultadoDesencriptado(string password);
    }
}