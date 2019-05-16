using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caTratamentoExcecao
{
    class Program
    {
        public static int quociente(int numerador, int denominador)
        {
            return (numerador / denominador);
        }

        static void Main(string[] args)
        {
            int numerador, denominador;

            Console.WriteLine("Entre o numerador: ");
            numerador = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entre o denominador: ");
            denominador = Convert.ToInt32(Console.ReadLine());

            double resultado = quociente(numerador, denominador);

            Console.WriteLine("Resultado = " + resultado);
            Console.ReadLine();
        }
    }
}
