using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caTratamentoExcecao2
{
    class Program
    {
        public static int quociente(int numerador, int denominador)
        {
            return (numerador / denominador);
        }

        static void Main(string[] args)
        {
            bool continueLoop = true;

            do
            {
                try
                {
                    int numerador, denominador;

                    Console.WriteLine("Entre o numerador: ");
                    numerador = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Entre o denominador: ");
                    denominador = Convert.ToInt32(Console.ReadLine());

                    double resultado = quociente(numerador, denominador);

                    Console.WriteLine("Resultado = " + resultado);
                    Console.ReadLine();
                    continueLoop = false;
                }

                catch (FormatException)
                {
                    Console.WriteLine("Precisa ser número inteiro. Tente de novo");
                }

                //catch (DivideByZeroException divideByZeroException)
                //{
                //    Console.WriteLine(divideByZeroException + "\nNão existe divisão por zero, tente de novo");
                //}

                catch (Exception)
                {
                    Console.WriteLine("Erro não esperado, tente de novo");
                }

            } while (continueLoop);
            

            
        }
    }
}
