using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using caPilha;

namespace caPilhaTemplate
{
    class Program
    {
        static int Menu()
        {
            int choice;
            String choiceStr;
            Console.Clear();
            Console.WriteLine(
                "---------------MENU---------------\n" +
                "[1] Insira um item na pilha\n" +
                "[2] Remova um item da pilha\n" +
                "[3] Imprima a pilha\n" +
                "[4] Sair\n");
            choiceStr = Console.ReadLine();
            choice = int.Parse((choiceStr == "") ? "0" : choiceStr);
            return choice;
        }

        static void Main(string[] args)
        {
            bool exit = false;
            Pilha<String> pilhaStr = new Pilha<String>();
            Pilha<int> pilhaInt = new Pilha<int>();

            while (!exit)
            {
                switch (Menu())
                {
                    case 1:
                        Console.WriteLine("Insira a String");
                        pilhaStr.push(Console.ReadLine());
                        Console.WriteLine("Insira o Inteiro");
                        pilhaInt.push(int.Parse(Console.ReadLine()));
                        break;
                    case 2:
                        try
                        {
                            Console.WriteLine("String Removida: " + pilhaStr.pop());
                            Console.WriteLine("Inteiro Removido: " + pilhaInt.pop());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Pilha Vazia");
                        }
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Strings");
                        pilhaStr.print();
                        Console.WriteLine("\nInteiros");
                        pilhaInt.print();
                        Console.ReadLine();
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}