using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEstacionamentoTempo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Tempo t1 = new Tempo();
            Tempo t2 = new Tempo();
            t1.solicitaDados();
            t2.solicitaDados();
            Tempo t3 = t1.soma(t2);
            t3.print();
            Tempo t4 = t1.subtrai(t2);
            t4.print();
            */

            Estacionamento estacionamento = new Estacionamento();
            for (int i = 0; i < 2; i++)
            {
                estacionamento.novaEntrada();
            }
            estacionamento.relatorio();

            Console.ReadLine();
        }
    }
}
