using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caFila
{
    class Fila<ADT> : Object
    {
        private NoFila<ADT> fim, inicio;

        public Fila()
        {
            fim = inicio = null;
        }

        public bool isEmpty()
        {
            return (inicio == null)? false : true;
        }

        public void insere(ADT info)
        {
            NoFila<ADT> novoNo = new NoFila<ADT>(info);

            fim.setNext(novoNo);
            fim = novoNo;

            if (isEmpty()) { inicio = fim; }
        }

        public void imprime()
        {
            if (isEmpty())
            {
                Console.WriteLine("Fila Vazia");
            }
            else
            {

            }
        }

        public ADT remover() { }
    }
}
