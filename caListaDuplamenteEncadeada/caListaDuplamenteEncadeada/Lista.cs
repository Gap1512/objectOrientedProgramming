using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caListaDuplamenteEncadeada
{
    class Lista
    {
        private NohLista inicio, fim;

        public Lista()
        {
            inicio = fim = null;
        }

        public bool isEmpty()
        {
            return (inicio == null) ? true : false;
        }

        public void insereInicio(int data)
        {
            NohLista noh = new NohLista(data);

            if (isEmpty())
            {
                inicio = fim = noh;
            }
            else
            {
                inicio.setPrevio(noh);
                noh.setNext(inicio);
                inicio = noh;
            }
        }

        public void insereFim(int data)
        {
            NohLista noh = new NohLista(data);

            if (isEmpty())
            {
                inicio = fim = noh;
            }
            else
            {
                fim.setNext(noh);
                noh.setPrevio(fim);
                fim = noh;
            }
        }

        public void imprimeED()
        {
            string result = "Lista Atual: ";
            for (NohLista aux = inicio; aux != null; aux = aux.getNext())
            {
                result += aux.getData() + ((aux != fim) ? "->" : "");
            }
            Console.WriteLine(result);
        }

        public void imprimeDE()
        {
            string result = "Lista Atual: ";
            for (NohLista aux = fim; aux != null; aux = aux.getPrevio())
            {
                result += aux.getData() + ((aux != inicio) ? "<-" : "");
            }
            Console.WriteLine(result);
        }

        public void remove(int noh)
        {
            bool achou = false;
            if (isEmpty())
            {
                throw new Exception();
            }
            for (NohLista aux = inicio; aux != null; aux = aux.getNext())
            {
                if (aux.getData() == noh)
                {
                    if (aux == inicio)
                    {
                        inicio = inicio.getNext();
                        inicio.setPrevio(null);
                    }
                    else if (aux == fim)
                    {
                        fim = fim.getPrevio();
                        fim.setNext(null);
                    }
                    else
                    {
                        aux.getPrevio().setNext(aux.getNext());
                        aux.getNext().setPrevio(aux.getPrevio());
                    }
                    achou = true;
                    break;
                }
            }
            if (!achou)
            {
                Console.Error.WriteLine("Item não encontrado");
                throw new Exception();
            }
        }
    }
}
