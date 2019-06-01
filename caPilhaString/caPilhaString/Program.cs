using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using caPilha;

namespace caPilhaString
{
    class Program
    {
        static int Menu()
        {
            int choice;
            Console.Clear();
            Console.WriteLine(
                "---------------MENU---------------\n" +
                "[1] Insira uma string na pilha\n" +
                "[2] Remova uma string da pilha\n" +
                "[3] Imprima uma pilha de strings\n" +
                "[4] Sair\n");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }

        static void Main(string[] args)
        {
            bool exit = false;
            Pilha pilha = new Pilha();

            while (!exit)
            {
                switch (Menu())
                {
                    case 1:
                        Console.WriteLine("Insira a String");
                        pilha.push(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Item Removido: " + pilha.pop());
                        Console.ReadLine();
                        break;
                    case 3:
                        pilha.print();
                        Console.ReadLine();
                        break;
                    case 4:
                        exit = true;
                        break;
                }
            }
        }
    }
}
