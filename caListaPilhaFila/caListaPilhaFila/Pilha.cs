using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caListaPilhaFila
{
    class Pilha<T> : Lista<T>
    {
        public Pilha() : base()
        {

        }

        public override void imprime()
        {
            if (estaVazia())
            {
                Console.WriteLine("Pilha Vazia");
            }
            else
            {
                Console.WriteLine("Pilha Atual: ");
                NohLista<T> aux = inicio;
                while (aux != null)
                {
                    Console.WriteLine(aux.getData());
                    aux = aux.getNext();
                }
            }
        }
    }
}
