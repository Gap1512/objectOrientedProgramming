using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEstacionamentoTempo
{
    class Carro
    {
        //Atributos
        private String chapa, marca;
        private Tempo entrada, saida;
        //-----------------------------------------------------------------
        //Métodos
        //-----------------------------------------------------------------
        //-Construtores
        public Carro(String _chapa, String _marca, Tempo _entrada, Tempo _saida)
        {
            chapa = _chapa;
            marca = _marca;
            entrada = _entrada;
            saida = _saida;
        }
        //-----------------------------------------------------------------
        //-Getters
        public String getChapa()
        {
            return chapa;
        }

        public String getMarca()
        {
            return marca;
        }

        public Tempo getEntrada()
        {
            return entrada;
        }

        public Tempo getSaida()
        {
            return saida;
        }
        //-----------------------------------------------------------------
        //-Setters
        public void setChapa(String _chapa)
        {
            chapa = _chapa;
        }

        public void setMarca(String _marca)
        {
            marca = _marca;
        }

        public void setEntrada(Tempo _entrada)
        {
            entrada = _entrada;
        }

        public void setSaida(Tempo _saida)
        {
            saida = _saida;
        }
        //-----------------------------------------------------------------
        //Outros Métodos
        public void print()
        {
            Console.WriteLine("Chapa: " + chapa + "\nMarca: " + marca);
            Console.Write("Entrada : ");
            entrada.print();
            Console.Write("Saída : ");
            saida.print();
        }
        //-----------------------------------------------------------------
    } //Fim da Classe
}
