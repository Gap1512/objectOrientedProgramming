using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilha
{
    class NohPilha
    {
        private String data;
        private NohPilha nextNoh;

        public NohPilha()
        {
            data = "";
            nextNoh = null;
        }

        public NohPilha(String valor)
        {
            data = valor;
            nextNoh = null;
        }

        public NohPilha(String valor, NohPilha noh)
        {
            data = valor;
            nextNoh = noh;
        }

        public String getData()
        {
            return data;
        }

        public NohPilha getNext()
        {
            return nextNoh;
        }

        public void setData(String data)
        {
            this.data = data;
        }

        public void setNext(NohPilha nextNoh)
        {
            this.nextNoh = nextNoh;
        }
    }
}
