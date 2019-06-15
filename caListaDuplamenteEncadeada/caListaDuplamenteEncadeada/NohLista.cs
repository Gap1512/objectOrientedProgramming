using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caListaDuplamenteEncadeada
{
    class NohLista
    {
        private NohLista previo, next;
        private int data;

        public NohLista()
        {
            previo = next = null;
            data = 0;
        }

        public NohLista(int data)
        {
            previo = next = null;
            this.data = data;
        }

        public NohLista(int data, NohLista previo, NohLista next)
        {
            this.previo = previo;
            this.data = data;
            this.next = next;
        }

        public int getData()
        {
            return data;
        }

        public NohLista getPrevio()
        {
            return previo;
        }

        public NohLista getNext()
        {
            return next;
        }

        public void setData(int data)
        {
            this.data = data;
        }

        public void setPrevio(NohLista previo)
        {
            this.previo = previo;
        }

        public void setNext(NohLista next)
        {
            this.next = next;
        }
    }
}
