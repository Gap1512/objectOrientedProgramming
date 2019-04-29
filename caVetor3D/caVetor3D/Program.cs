using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVetor3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Vetor3D v0 = new Vetor3D();
            Vetor3D v1 = new Vetor3D(15, 27, 06);
            Vetor3D v2 = new Vetor3D(09, 52, 12);
            Vetor3D i = new Vetor3D(1, 0, 0);
            Vetor3D j = new Vetor3D(0, 1, 0);
            Vetor3D k = new Vetor3D(0, 0, 1);


            Console.WriteLine(
                "Vetor i: " + i.print() + "\n" +
                "Vetor j: " + j.print() + "\n" +
                "Vetor k: " + k.print() + "\n" +
                "Vetor V0: " + v0.print() + "\n" +
                "Vetor V1: " + v1.print() + "\n" +
                "Vetor V2: " + v2.print() + "\n" +
                "Módulo de i: " + i.modulo() + "\n" +
                "Módulo de j: " + j.modulo() + "\n" +
                "Módulo de k: " + k.modulo() + "\n" +
                "Módulo de V0: " + v0.modulo() + "\n" +
                "Módulo de V1: " + v1.modulo() + "\n" +
                "Módulo de V2: " + v2.modulo() + "\n" +
                "V0 vetorial V1: " + v0.vetorial(v1).print() + "\n" +
                "V1 vetorial V0: " + v1.vetorial(v0).print() + "\n" +
                "V1 vetorial V2: " + v1.vetorial(v2).print() + "\n" +
                "V2 vetorial V1: " + v2.vetorial(v1).print() + "\n" +
                "i vetorial j: " + i.vetorial(j).print() + "\n" +
                "j vetorial i: " + j.vetorial(i).print());


            Console.ReadLine();
        }
    }
}
