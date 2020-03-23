using System;

namespace Exercicio2AgendaContatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();
            char digitado = 's';
            while (digitado != 'e')
            {
                Console.WriteLine("a. Ver lista completa");
                Console.WriteLine("b. Buscar contatos por letra");
                Console.WriteLine("c. Adicionar contato");
                Console.WriteLine("d. Remover contato");
                Console.WriteLine("e. Sair");
                Console.Write("\nDigite uma opcao:");
                digitado = char.Parse(Console.ReadLine());
                switch (digitado)
                {
                    case 'a':
                        Console.WriteLine("\nLista de contatos");
                        foreach (string contato in agenda.ListaCompleta)
                        {
                            Console.WriteLine(contato);
                        }

                        Console.WriteLine("\n");
                        break;
                    case 'b':
                        Console.Write("\nDigite uma letra:");
                        string letra = Console.ReadLine();
                        Console.WriteLine("\n Resultados da busca:");
                        foreach (string busca in agenda.BuscarContatoPorLetra(letra[0]))
                        {
                            Console.WriteLine(busca);
                        }
                        Console.WriteLine("\n");
                        break;
                    case 'c':
                        Console.Write("\nDigite um nome:");
                        string nome = Console.ReadLine();
                        agenda.AdicionarContato(nome);
                        Console.WriteLine("\n");
                        break;
                    case 'd':
                        Console.Write("\nDigite um nome:");
                        string removerNome = Console.ReadLine();
                        agenda.RemoverContato(removerNome);
                        Console.WriteLine("\n");
                        break;
                    case 'e':
                        Console.WriteLine("Saindo.....\n");
                        break;
                    default:
                        Console.WriteLine("Opcao invalida!!!!\n");
                        break;
                }
            }
        }
    }
}
