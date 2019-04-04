using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEstacionamentoTempo
{
    class Tempo
    {
        //Atributos
        private int hora, min, seg;
        //-----------------------------------------------------------------
        //-Construtor
        public Tempo()
        {
            hora = 0;
            min = 0;
            seg = 0;
        }

        private Tempo(int _hora, int _min, int _seg)
        {
            hora = _hora;
            min = _min;
            seg = _seg;
        }
        //-----------------------------------------------------------------
        //-Coletor de Dados
        public void solicitaDados()
        {
            do
            {
                Console.WriteLine("Insira a hora: ");
                hora = int.Parse(Console.ReadLine());
            } while (hora < 0 || hora > 23);

            do
            {
                Console.WriteLine("Insira os minutos: ");
                min = int.Parse(Console.ReadLine());
            } while (min < 0 || min > 59);

            do
            {
                Console.WriteLine("Insira os segundos: ");
                seg = int.Parse(Console.ReadLine());
            } while (seg < 0 || seg > 59);

        }
        //-----------------------------------------------------------------
        //Métodos
        //-----------------------------------------------------------------
        //-Getters
        public int getHora()
        {
            return hora;
        }

        public int getMin()
        {
            return min;
        }

        public int getSeg()
        {
            return seg;
        }
        //-----------------------------------------------------------------
        //-Setters
        public void setHora(int _hora)
        {
            hora = _hora;
        }

        public void setMin(int _min)
        {
            min = _min;
        }

        public void setSeg(int _seg)
        {
            seg = _seg;
        }
        //-----------------------------------------------------------------
        //-Printer
        public void print()
        {
            Console.WriteLine(hora + ":" + min + ":" + seg);
        }
        //-----------------------------------------------------------------
        //-Outros Métodos
        public Tempo soma(Tempo t)
        {
            int _hora, _min, _seg;
            _seg = seg + t.getSeg();
            _min = min + t.getMin();
            _hora = hora + t.getHora();

            if (_seg > 59)
            {
                _seg = _seg - 60;
                _min++;
            }

            if (_min > 59)
            {
                _min = _min - 60;
                _hora++;
            }

            if (_hora > 23)
            {
                _hora = _hora - 24;
            }
            return new Tempo(_hora, _min, _seg);
        }

        public Tempo subtrai(Tempo t)
        {
            int _hora, _min, _seg;
            _seg = seg - t.getSeg();
            _min = min - t.getMin();
            _hora = hora - t.getHora();

            if (_seg < 0)
            {
                _seg = _seg + 60;
                _min--;
            }

            if (_min < 0)
            {
                _min = _min + 60;
                _hora--;
            }

            if (_hora < 0)
            {
                _hora = _hora + 24;
            }
            return new Tempo(_hora, _min, _seg);
        }
        //-----------------------------------------------------------------
    } //Fim da Classe
}
