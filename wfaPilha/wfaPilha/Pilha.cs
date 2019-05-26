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

        public void push(int valor)
        {
            topo = new NohPilha(valor, topo);
        }

        public int pop()
        {
            if (isEmpty())
            {
                throw new Exception();
            }
            int aux = topo.getData();
            topo = topo.getNext();
            return aux;
        }

        public string print()
        {
            string resultado = "";
            if (!isEmpty())
            {
                NohPilha aux = topo;
                while (aux != null)
                {
                    resultado += aux.getData() + "\r\n";
                    aux = aux.getNext();
                }
            }
            return resultado;
        }

        public string inversePrint()
        {
            List<int> resultados = new List<int>();
            string resultado = "";
            NohPilha aux = topo;
            while (aux != null)
            {
               resultados.Add(aux.getData());
               aux = aux.getNext();
            }
            resultados.Reverse();
            for (int i = 0; i < resultados.Count; i++)
            {
                resultado += resultados[i] + "\r\n";
            }
            return resultado;
        }

        public int menor()
        {
            int menor;
            if (!isEmpty())
            {
                NohPilha aux = topo;
                menor = aux.getData();
                while (aux != null)
                {
                    if (menor > aux.getData()){
                        menor = aux.getData();
                    }
                    aux = aux.getNext();
                }
            }
            else
            {
                throw new Exception();
            }
            return menor;
        }

        public int maior()
        {
            int maior;
            if (!isEmpty())
            {
                NohPilha aux = topo;
                maior = aux.getData();
                while (aux != null)
                {
                    if (maior < aux.getData())
                    {
                        maior = aux.getData();
                    }
                    aux = aux.getNext();
                }
            }
            else
            {
                throw new Exception();
            }
            return maior;
        }
    }
}
