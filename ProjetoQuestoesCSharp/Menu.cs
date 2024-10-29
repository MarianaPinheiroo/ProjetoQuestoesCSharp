using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp
{
    public class Menu
    {
        public void ExibirMenu()
        {
            Questoes questoes = new Questoes();
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("*** 100 Questões ***");
                Console.WriteLine(" por favor escolha a questão desejada ou digite 0 para sair:");

                if (int.TryParse(Console.ReadLine(), out int questao) && questao >= 0 && questao <= 100)
                {
                    if (questao == 0)
                    {
                        continuar = false;
                        Console.WriteLine("Encerrando o programa...");
                    }
                    else
                    {
                        questoes.ExecutarQuestao(questao);
                        Console.WriteLine("\nPressione qualquer tecla para retornar ao menu de questões.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Insira insira um número de questão válido.");
                }
            }
        }
    }
}
