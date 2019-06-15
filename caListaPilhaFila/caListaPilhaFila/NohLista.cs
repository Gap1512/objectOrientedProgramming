using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caListaPilhaFila
{
    class NohLista<T> : Object
    {
        private NohLista<T> previo, next;
        private T data;

        public NohLista()
        {
            previo = next = null;
        }

        public NohLista(T data)
        {
            previo = next = null;
            this.data = data;
        }

        public NohLista(T data, NohLista<T> previo, NohLista<T> next)
        {
            this.previo = previo;
            this.data = data;
            this.next = next;
        }

        public T getData()
        {
            return data;
        }

        public NohLista<T> getPrevio()
        {
            return previo;
        }

        public NohLista<T> getNext()
        {
            return next;
        }

        public void setData(T data)
        {
            this.data = data;
        }

        public void setPrevio(NohLista<T> previo)
        {
            this.previo = previo;
        }

        public void setNext(NohLista<T> next)
        {
            this.next = next;
        }
    }
}
