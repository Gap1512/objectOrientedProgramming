using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVector2D
{
    class Program
    {
        static void Main(string[] args)
        {
            Vetor2D a1 = new Vetor2D();
            Vetor2D a2 = new Vetor2D(1, 1);
            Vetor2D i = new Vetor2D(1, 0);
            Vetor2D j = new Vetor2D(0, 1);

            Console.WriteLine("Valores Iniciais: ");
            a1.print();
            a2.print();

            a1.setX(10);
            a2.setY(5);

            Console.WriteLine("Valores Atualizados: ");
            a1.print();
            a2.print();

            Console.WriteLine("Produtos Escalares: ");
            Console.WriteLine(a1.escalar(a2));
            Console.WriteLine(a2.escalar(a1));
            Console.WriteLine(i.escalar(j));

            Console.WriteLine("Modulos: ");
            Console.WriteLine(a1.modulo());
            Console.WriteLine(a2.modulo());
            Console.WriteLine("|i|: " + i.modulo());
            Console.WriteLine("|j|: " + j.modulo());

            Console.WriteLine("Angulos: ");
            Console.WriteLine(a1.anguloDeg(a2));
            Console.WriteLine(a2.anguloRad(a1));
            Console.WriteLine(i.anguloDeg(j));

            Console.WriteLine("Projeções: ");
            Console.WriteLine(a1.projecaoEm(a2));
            Console.WriteLine(a2.projecaoEm(a1));
            Console.WriteLine(a1.projecaoEm(i));
            Console.WriteLine(i.projecaoEm(j));

            Console.ReadLine();
        }
    }
}
