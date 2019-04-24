using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno A1 = new Aluno();
            Aluno A2 = new Aluno("Gustavo Alves Pacheco", 20, "Engenharia de Computação");

            A1.imprimeDados();
            A2.imprimeDados();

            Console.ReadLine();
        }
    }
}
