using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilha
{
    class Pilha<TAD> : Object
    {
        private NohPilha<TAD> topo;

        public Pilha()
        {
            topo = null;
        }

        public bool isEmpty()
        {
            return (topo == null) ? true : false;
        }

        public void push(TAD valor)
        {
            topo = new NohPilha<TAD>(valor, topo);
        }

        public TAD pop()
        {
            if (isEmpty())
            {
                throw new Exception();
            }
            TAD aux = topo.getData();
            topo = topo.getNext();
            return aux;
        }

        public void print()
        {
            if (isEmpty())
            {
                Console.WriteLine("Pilha Vazia");
            }
            else
            {
                Console.WriteLine("Status Atual da Pilha");
                NohPilha<TAD> aux = topo;
                while (aux != null)
                {
                    Console.WriteLine(aux.getData());
                    aux = aux.getNext();
                }                
            }
        }
    }
}
