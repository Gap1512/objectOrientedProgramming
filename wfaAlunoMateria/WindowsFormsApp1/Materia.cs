using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAlunoMaterias
{
    class Materia
    {
        //Properties

        private String nome;
        private String codigo;

        //Methods

        //Constructor
        
        public Materia()
        {
            nome = "";
            codigo = "";
        }

        public Materia(String _nome, String _codigo)
        {
            nome = _nome;
            codigo = _codigo;
        }

        //Get

        public String getNome()
        {
            return nome;
        }

        public String getCodigo()
        {
            return codigo;
        }

        //Set

        public void setNome(String _nome)
        {
            nome = _nome;
        }

        public void setCodigo(String _codigo)
        {
            codigo = _codigo;
        }

    } //End of Class
}
