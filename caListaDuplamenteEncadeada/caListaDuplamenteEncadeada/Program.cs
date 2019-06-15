using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caListaDuplamenteEncadeada
{
    class Program
    {
        static int Menu()
        {
            int choice;
            Console.Clear();
            Console.WriteLine(
                "---------------MENU---------------\n" +
                "[1] Inserir um inteiro no início da lista\n" +
                "[2] Inserir um inteiro no fim da lista\n" +
                "[3] Remover um inteiro da lista\n" +
                "[4] Imprimir a lista da esquerda para a direita\n" +
                "[5] Imprimir a lista da direita para a esquerda\n" +
                "[6] Sair\n");
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
            Lista lista = new Lista();

            while (!exit)
            {
                switch (Menu())
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
                        exit = true;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
