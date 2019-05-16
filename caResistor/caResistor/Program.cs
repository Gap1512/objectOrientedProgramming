using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caResistor
{
    class Program
    {
        static void Main(string[] args)
        {
            double resistenciaAux, pMaxAux;
            Resistor r1, r2;

            Console.WriteLine("Insira os dados do resistor 1");
            Console.WriteLine("Resistência: ");
            resistenciaAux = double.Parse(Console.ReadLine());
            Console.WriteLine("Potência Máxima: ");
            pMaxAux = double.Parse(Console.ReadLine());

            r1 = new Resistor(resistenciaAux, pMaxAux);

            Console.WriteLine("\nInsira os dados do resistor 2");
            Console.WriteLine("Resistência: ");
            resistenciaAux = double.Parse(Console.ReadLine());
            Console.WriteLine("Potência Máxima: ");
            pMaxAux = double.Parse(Console.ReadLine());

            r2 = new Resistor(resistenciaAux, pMaxAux);

            Console.WriteLine("\nResistor 1");
            r1.imprimeResistor();
            Console.WriteLine("\nResistor 2");
            r2.imprimeResistor();


            Console.WriteLine("\nR1 em série com R2");
            (r1.resistorSerie(r2)).imprimeResistor();
            Console.WriteLine("\nR1 em paralelo com R2");
            (r1.resistorParalelo(r2)).imprimeResistor();

            Console.ReadLine();
        }
    }
}
