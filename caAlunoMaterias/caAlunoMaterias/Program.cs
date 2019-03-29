using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAlunoMaterias
{
    class Program
    {

        static string recordName()
        {
            Console.WriteLine("Digite o nome do aluno:");
            Console.ReadLine();
            return "Teste Nome";
        }

        static void Main(string[] args)
        {
            Aluno a1 = new Aluno("Ze Mane", "10111ECP123", 5);
            Materia m1 = new Materia("POO", "FEELT134");
            Materia m2 = new Materia("ED", "FEELT138");
            a1.associaMateria(m1);
            a1.associaMateria(m2);
            a1.imprimeRelatorio();
            Console.ReadLine();

            //Aluno teste = new Aluno(recordName(), "123456", 1);
            //Console.WriteLine(teste.getNome());
            //Console.ReadLine();

        }
    }
}
