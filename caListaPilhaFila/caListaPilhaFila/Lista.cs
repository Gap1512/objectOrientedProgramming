using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caListaPilhaFila
{
    class Lista<T> : Object
    {
        protected NohLista<T> inicio, fim;

        public Lista()
        {
            inicio = fim = null;
        }

        public bool estaVazia()
        {
            return (inicio == null) ? true : false;
        }

        public void insereInicio(T data)
        {
            NohLista<T> noh = new NohLista<T>(data);

            if (estaVazia())
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

        public void insereFim(T data)
        {
            NohLista<T> noh = new NohLista<T>(data);

            if (estaVazia())
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

        public virtual void imprime() { }

        public void imprimeED()
        {
            if (estaVazia())
            {
                Console.WriteLine("Lista Vazia");
            }
            else
            {
                string result = "Lista Atual: ";
                for (NohLista<T> aux = inicio; aux != null; aux = aux.getNext())
                {
                    result += aux.getData() + ((aux != fim) ? "->" : "");
                }
                Console.WriteLine(result);
            }
        }

        public void imprimeDE()
        {
            if (estaVazia())
            {
                Console.WriteLine("Lista Vazia");
            }
            else
            {
                string result = "Lista Atual: ";
                for (NohLista<T> aux = fim; aux != null; aux = aux.getPrevio())
                {
                    result += aux.getData() + ((aux != inicio) ? "<-" : "");
                }
                Console.WriteLine(result);
            }
        }

        public NohLista<T> encontraNoh(T noh)
        {
            for (NohLista<T> aux = inicio; aux != null; aux = aux.getNext())
            {
                if (aux.getData().Equals(noh))
                {
                    return aux;
                }
            }
            throw new Exception("Objeto não encontrado.");
        }

        public void remove(T noh)
        {
            try
            {
                NohLista<T> aux = encontraNoh(noh);
                if (aux == inicio && aux == fim)
                {
                    inicio = fim = null;
                }
                else if (aux == inicio)
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
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public T removeInicio()
        {
            if (estaVazia())
            {
                throw new Exception("Vazia");
            }
            T aux = inicio.getData();
            inicio = inicio.getNext();
            return aux;
        }

        public T removeFim()
        {
            if (estaVazia())
            {
                throw new Exception("Vazia");
            }
            T aux = fim.getData();
            fim = fim.getPrevio();
            return aux;
        }
    }
}
