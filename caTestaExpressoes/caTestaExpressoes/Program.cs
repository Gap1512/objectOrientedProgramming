using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using caPilha;

namespace caTestaExpressoes
{
    class Program
    {

        static List<char> abridores = new List<char> { '{', '[', '(' };
        static List<char> fechadores = new List<char> { '}', ']', ')' };

        static int Menu()
        {
            int choice;
            Console.Clear();
            Console.WriteLine(
                "---------------MENU---------------\n" +
                "[1] Testar Uma Expressão Matemática\n" +
                "[2] Sair\n");
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

        static bool testaExpressoes(String expressao)
        {
            Pilha<char> pilha = new Pilha<char>();

            if (expressao == "")
            {
                throw new Exception();
            }

            foreach (char elemento in expressao)
            {
                if (abridores.Contains(elemento))
                {
                    pilha.push(elemento);
                }
                else if (fechadores.Contains(elemento))
                {
                    try
                    {
                        char aux = pilha.pop();
                        switch (aux)
                        {
                            case '{':
                                if (elemento != '}')
                                {
                                    return false;
                                }
                                break;
                            case '[':
                                if (elemento != ']')
                                {
                                    return false;
                                }
                                break;
                            case '(':
                                if (elemento != ')')
                                {
                                    return false;
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
            }

            return (pilha.isEmpty()) ? true : false;
        }

        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                switch (Menu())
                {
                    case 1:
                        Console.WriteLine("Insira a Expressão");
                        try
                        {
                            Console.WriteLine(testaExpressoes(Console.ReadLine()) ? "Correta" : "Incorreta");
                        }
                        catch (Exception)
                        {
                            Console.Error.WriteLine("Erro, Expressão Inválida");
                        }
                        finally
                        {
                            Console.ReadLine();
                        }
                        break;
                    case 2:
                        exit = true;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
