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

        static void imprimeMenu()
        {
            Console.WriteLine(
                        "Escolha uma opção do menu:\n" +
                        "[1] - Cadastrar um aluno\n" +
                        "[2] - Cadastrar uma disciplina\n" +
                        "[3] - Associar uma disciplina a um aluno\n" +
                        "[4] - Imprimir relatório\n" +
                        "[5] - Sair\n");
        }

        static Aluno achaAluno(String nome_aluno, List<Aluno> alunos)
        {
            Aluno achei_aluno = null;
            for(int i = 0; i < alunos.Count(); i++)
            {
                if(nome_aluno == alunos[i].getNome())
                {
                    achei_aluno = alunos[i];
                    break;
                }
            }
            return achei_aluno;
        }

        static Materia achaMateria(String nome_materia, List<Materia> materias)
        {
            Materia achei_materia = null;
            for (int i = 0; i < materias.Count(); i++)
            {
                if (nome_materia == materias[i].getNome())
                {
                    achei_materia = materias[i];
                    break;
                }
            }
            return achei_materia;
        }

        static void Main(string[] args)
        {
            string nome_aluno, matricula, nome_materia, codigo_materia;
            int periodo;
            Aluno al;
            Materia ma;

            /*
            Aluno a1 = new Aluno("Ze Mane", "10111ECP123", 5);
            Materia m1 = new Materia("POO", "FEELT134");
            Materia m2 = new Materia("ED", "FEELT138");
            a1.associaMateria(m1);
            a1.associaMateria(m2);
            a1.imprimeRelatorio();
            Console.ReadLine();
            */
            //Aluno teste = new Aluno(recordName(), "123456", 1);
            //Console.WriteLine(teste.getNome());
            //Console.ReadLine();

            List<Aluno> listaAlunos = new List<Aluno>();
            List<Materia> listaMaterias = new List<Materia>();

            /*Menu*/
            int aux = 1;
            while (aux != 0)
            {
                imprimeMenu();

                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine(
                            "Cadastrar um aluno\n" +
                            "Entre o nome do aluno");
                        nome_aluno = Console.ReadLine();
                        Console.WriteLine("Entre a matrícula do aluno");
                        matricula = Console.ReadLine();
                        Console.WriteLine("Entre o período do aluno");
                        periodo = int.Parse(Console.ReadLine());
                        Aluno a = new Aluno(nome_aluno, matricula, periodo);
                        listaAlunos.Add(a);
                        Console.Clear();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine(
                            "Cadastrar uma matéria\n" +
                            "Entre o nome da matéria");
                        nome_materia = Console.ReadLine();
                        Console.WriteLine("Entre o código da matéria");
                        codigo_materia = Console.ReadLine();
                        Materia m = new Materia(nome_materia, codigo_materia);
                        listaMaterias.Add(m);
                        Console.Clear();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Associar uma matéria a um aluno\n" +
                            "Escolha um aluno");

                        for (int i = 0; i < listaAlunos.Count; i++)
                        {
                            Console.WriteLine(((Aluno)listaAlunos[i]).getNome());
                        }

                        al = achaAluno(Console.ReadLine(), listaAlunos);

                        Console.WriteLine("Escolha uma matéria");
                        for (int i = 0; i < listaMaterias.Count; i++)
                        {
                            Console.WriteLine(((Materia)listaMaterias[i]).getNome());
                        }

                        ma = achaMateria(Console.ReadLine(), listaMaterias);

                        al.associaMateria(ma);

                        Console.Clear();
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Imprimir relatório\n" +
                            "Escolha um aluno");

                        for (int i = 0; i < listaAlunos.Count; i++)
                        {
                            Console.WriteLine(((Aluno)listaAlunos[i]).getNome());
                        }
                        
                        ((Aluno)achaAluno(Console.ReadLine(), listaAlunos)).imprimeRelatorio();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "5":
                        aux = 0;
                        Console.Clear();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Favor inserir comando válido\n");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
