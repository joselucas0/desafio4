using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio4
{
    public class MenuEleitor : IMenu
    {
        public void ExibirMenu()
        {
            Console.WriteLine("=== Menu Eleitor ===");
            Console.WriteLine("1. Votar");
            Console.WriteLine("2. Sair");
        public void ExecutarOpcao(int opcao, Administrador adm)
        {
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Votando...");
                    Votar(eleitor, Eleicao);
                    break;
                case 2:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    
                    break;
            }
        }

        public void Votar(Eleitor eleitor, Eleicao Eleicao)
        {
            while (true)
            {
                System.Console.WriteLine("Digite o numero do candidato:");
                Candidato candidato = Eleicao.Candidatos.Find(voto => voto.NumeroIndentificador == int.Parse(Console.ReadLine()));


                if (candidato == null)
                {
                    Console.WriteLine("Candidato não encontrado!");
                }
                else
                {
                    System.Console.WriteLine("Confirma seu voto? (s/n)");
                    string confirmacao = Console.ReadLine();
                    while (confirmacao == "n" || confirmacao == "N")
                    {
                        System.Console.WriteLine("Digite o numero do candidato:");
                        candidato = Eleicao.Candidatos.Find(voto => voto.NumeroIndentificador == int.Parse(Console.ReadLine()));

                        System.Console.WriteLine("Confirma seu voto? (s/n)");
                        confirmacao = Console.ReadLine();
                    }

                    System.Console.WriteLine("Voto registrado com sucesso!");
                    Voto voto = new Voto(candidato, eleitor);
                    Eleicao.VotosCsv.Add(voto.ToString());
                    Eleicao.Votos.Add(voto);
                    Eleicao.Candidatos.Add(candidato);
                    return;
                }
            }
        }
    }
}
}