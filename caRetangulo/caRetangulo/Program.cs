using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            //criando objeto da classe Retangulo
            Retangulo r1 = new Retangulo();

            Console.WriteLine(r1.getBasis());

            r1.setBasis(25.0); 

            Console.WriteLine(r1.getBasis());
            Console.WriteLine(r1.getAltura());
            Console.WriteLine();

            Retangulo r2 = new Retangulo(15.0, 25.0);


            Console.WriteLine(r2.getBasis());
            Console.WriteLine(r2.getAltura());
            Console.WriteLine();

            Console.WriteLine(r1.Area());
            Console.WriteLine(r2.Area());
            Console.WriteLine();

            Console.WriteLine(r1.Perimetro());
            Console.WriteLine(r2.Perimetro());
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
