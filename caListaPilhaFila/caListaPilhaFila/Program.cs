using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caListaPilhaFila
{
    class Program
    {
        static int menu()
        {
            int choice;
            Console.Clear();
            Console.WriteLine(
                "---------------MENU---------------\n" +
                "[1] Criar uma lista de inteiros\n" +
                "[2] Criar uma fila de inteiros\n" +
                "[3] Criar uma pilha de inteiros\n" +
                "[4] Sair\n");
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                choice = 0;
            }

            return choice;
        }

        static int altMenu(string dataType)
        {
            int choice;
            Console.Clear();
            switch (dataType)
            {
                case "lista":
                    Console.WriteLine(
                        "---------------MENU---------------\n" +
                        "[1] Inserir um inteiro no início da lista\n" +
                        "[2] Inserir um inteiro no fim da lista\n" +
                        "[3] Remover um inteiro da lista\n" +
                        "[4] Imprimir a lista da esquerda para a direita\n" +
                        "[5] Imprimir a lista da direita para a esquerda\n" +
                        "[6] Voltar\n");
                    break;
                case "pilha":
                    Console.WriteLine(
                        "---------------MENU---------------\n" +
                        "[1] Insira um item na pilha\n" +
                        "[2] Remova um item da pilha\n" +
                        "[3] Imprima a pilha\n" +
                        "[4] Voltar\n");
                    break;
                case "fila":
                    Console.WriteLine(
                        "---------------MENU---------------\n" +
                        "[1] Insira um item na fila\n" +
                        "[2] Remova um item da fila\n" +
                        "[3] Imprima a fila\n" +
                        "[4] Voltar\n");
                    break;
                default:
                    break;
            }
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                choice = 0;
            }

            return choice;
        }

        static void Main(string[] args)
        {
            bool exit = false;
            Lista<int> lista = new Lista<int>();
            Pilha<int> pilha = new Pilha<int>();
            Fila<int> fila = new Fila<int>();

            while (!exit)
            {
                bool voltar = false;

                switch (menu())
                {
                    case 1:
                        lista = new Lista<int>();
                        while (!voltar)
                        {
                            switch (altMenu("lista"))
                            {
                                case 1:
                                    Console.WriteLine("Digite o valor a ser inserido");
                                    try
                                    {
                                        lista.insereInicio(int.Parse(Console.ReadLine()));
                                        Console.WriteLine("Item inserido com sucesso");
                                    }
                                    catch (Exception)
                                    {
                                        Console.Error.WriteLine("Erro ao inserir item");
                                    }
                                    Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Digite o valor a ser inserido");
                                    try
                                    {
                                        lista.insereFim(int.Parse(Console.ReadLine()));
                                        Console.WriteLine("Item inserido com sucesso");
                                    }
                                    catch (Exception)
                                    {
                                        Console.Error.WriteLine("Erro ao inserir item");
                                    }
                                    Console.ReadLine();
                                    break;
                                case 3:
                                    lista.imprimeED();
                                    Console.WriteLine("Digite o valor a ser removido");
                                    try
                                    {
                                        lista.remove(int.Parse(Console.ReadLine()));
                                        Console.WriteLine("Item removido com sucesso");
                                    }
                                    catch (Exception)
                                    {
                                        Console.Error.WriteLine("Erro ao remover item");
                                    }
                                    finally
                                    {
                                        Console.ReadLine();
                                    }
                                    break;
                                case 4:
                                    lista.imprimeED();
                                    Console.ReadLine();
                                    break;
                                case 5:
                                    lista.imprimeDE();
                                    Console.ReadLine();
                                    break;
                                case 6:
                                    voltar = true;
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case 2:
                        fila = new Fila<int>();
                        while (!voltar)
                        {
                            switch (altMenu("fila"))
                            {
                                case 1:
                                    Console.WriteLine("Digite o valor a ser inserido");
                                    try
                                    {
                                        fila.insereInicio(int.Parse(Console.ReadLine()));
                                        Console.WriteLine("Item inserido com sucesso");
                                    }
                                    catch (Exception)
                                    {
                                        Console.Error.WriteLine("Erro ao inserir item");
                                    }
                                    Console.ReadLine();
                                    break;
                                case 2:
                                    try
                                    {
                                        Console.WriteLine("Item removido :" + fila.removeFim());
                                    }
                                    catch (Exception)
                                    {
                                        Console.Error.WriteLine("Erro ao remover item");
                                    }
                                    finally
                                    {
                                        Console.ReadLine();
                                    }
                                    break;
                                case 3:
                                    fila.imprime();
                                    Console.ReadLine();
                                    break;
                                case 4:
                                    voltar = true;
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case 3:
                        pilha = new Pilha<int>();
                        while (!voltar)
                        {
                            switch (altMenu("pilha"))
                            {
                                case 1:
                                    Console.WriteLine("Digite o valor a ser inserido");
                                    try
                                    {
                                        pilha.insereInicio(int.Parse(Console.ReadLine()));
                                        Console.WriteLine("Item inserido com sucesso");
                                    }
                                    catch (Exception)
                                    {
                                        Console.Error.WriteLine("Erro ao inserir item");
                                    }
                                    Console.ReadLine();
                                    break;
                                case 2:
                                    try
                                    {
                                        Console.WriteLine("Item removido :" + pilha.removeInicio());
                                    }
                                    catch (Exception)
                                    {
                                        Console.Error.WriteLine("Erro ao remover item");
                                    }
                                    finally
                                    {
                                        Console.ReadLine();
                                    }
                                    break;
                                case 3:
                                    pilha.imprime();
                                    Console.ReadLine();
                                    break;
                                case 4:
                                    voltar = true;
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case 4:
                        lista.imprimeED();
                        fila.imprime();
                        pilha.imprime();
                        Console.ReadLine();
                        exit = true;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
