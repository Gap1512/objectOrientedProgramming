using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilha
{
    class Pilha
    {
        private NohPilha topo;

        public Pilha()
        {
            topo = null;
        }

        public bool isEmpty()
        {
            return (topo == null) ? true : false;
        }

        public void push(String valor)
        {
            topo = new NohPilha(valor, topo);
        }

        public String pop()
        {
            if (isEmpty())
            {
                throw new Exception();
            }
            String aux = topo.getData();
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
                NohPilha aux = topo;
                while (aux != null)
                {
                    Console.WriteLine(aux.getData());
                    aux = aux.getNext();
                }                
            }
        }
    }
}
