using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAlunoMaterias
{
    class Aluno
    {
        //Properties

        private String nome;
        private String numero_matricula;
        private int periodo;
        private Materia[] lista_materias;
        private int i;

        //Methods

        ///Constructor

        public Aluno()
        {
            nome = "";
            numero_matricula = "";
            periodo = 0;
            lista_materias = new Materia[8];
            i = 0;
        }

        public Aluno(String _nome, String _numero_matricula, int _periodo)
        {
            nome = _nome;
            numero_matricula = _numero_matricula;
            periodo = _periodo;
            lista_materias = new Materia[8];
            i = 0;
        }

        ///Get

        public String getNome()
        {
            return nome;
        }

        public String getNumeroMatricula()
        {
            return numero_matricula;
        }

        public int getPeriodo()
        {
            return periodo;
        }

        public Materia getMateria(int _number)
        {
            return lista_materias[_number];
        }

        public Array getMaterias()
        {
            return lista_materias;
        }

        ///Set

        public void setNome(String _nome)
        {
            nome = _nome;
        }

        public void setNumeroMatricula(String _numero_matricula)
        {
            numero_matricula = _numero_matricula;
        }

        public void setPeriodo(int _periodo)
        {
            periodo = _periodo;
        }

        // Other Methods

        public void associaMateria(Materia _materia)
        {
            if (i < 8)
            {
                lista_materias[i] = _materia;
                i++;
            }
            else
            {
                Console.WriteLine("Número máximo de matérias permitidas foi alcançadas");
            }
        }

        public List<String> imprimeRelatorio()
        {
            List<String> materias = new List<string>();

            for (int j = 0; j < i; j++)
            {
                materias.Add("Matéria " + (j + 1) + " " + lista_materias[j].getNome());
            }

            return materias;
        }

    } //End of Class
}