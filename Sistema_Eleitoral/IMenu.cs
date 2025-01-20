using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio4
{
    public interface IMenu
    {
        void ExibirMenu();
        public void ExecutarOpcao(int opcao, Administrador adm);
    }
}