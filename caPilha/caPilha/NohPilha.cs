using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilha
{
    class NohPilha
    {
        private int data;
        private NohPilha nextNoh;

        public NohPilha()
        {
            data = 0;
            nextNoh = null;
        }

        public NohPilha(int valor)
        {
            data = valor;
            nextNoh = null;
        }

        public NohPilha(int valor, NohPilha noh)
        {
            data = valor;
            nextNoh = noh;
        }

        public int getData()
        {
            return data;
        }

        public NohPilha getNext()
        {
            return nextNoh;
        }

        public void setData(int data)
        {
            this.data = data;
        }

        public void setNext(NohPilha nextNoh)
        {
            this.nextNoh = nextNoh;
        }
    }
}
