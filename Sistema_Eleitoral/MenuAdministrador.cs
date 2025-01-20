using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio4
{
    public class MenuAdministrador : IMenu
        {            
            public void ExibirMenu()
            {
                Console.WriteLine("=== Menu Administrador ===");
                Console.WriteLine("1. Adicionar Eleitor");
                Console.WriteLine("2. Exibir Todos os Votos");
                Console.WriteLine("3. Sair");
            }


            public void ExecutarOpcao(int opcao, Administrador adm)
            {
                switch (opcao)
                {
                    
                    case 1:

                        Console.WriteLine("Adicionar Candidato");
                        System.Console.WriteLine("Digite o nome do candidato: ");
                        string name = Console.ReadLine();

                        System.Console.WriteLine("Qual o Cargo do candidato: ");
                        string cargo = Console.ReadLine();
                        
                        System.Console.WriteLine("Digite o Numero Indentificador do candidato: ");
                        int Num = Convert.ToInt32(Console.ReadLine());
        
                        adm.CadastrarCandidato(name, cargo, Num );

                        break;

                    case 2:
                        Console.WriteLine("Listar votos");

                                                                                                                                                                
    
                        break;
                    case 3:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

    
}