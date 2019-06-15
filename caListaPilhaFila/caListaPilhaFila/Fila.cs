using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caListaPilhaFila
{
    class Fila<T> : Lista<T>
    {
        public Fila() : base()
        {

        }

        public override void imprime()
        {
            if (estaVazia())
            {
                Console.WriteLine("Fila Vazia");
            }
            else
            {
                string result = "Fila Atual: ";
                NohLista<T> noFila = inicio;
                while (noFila != null)
                {
                    result += noFila.getData() + " ";
                    noFila = noFila.getNext();
                }
                Console.WriteLine(result);
            }
        }
    }
}
