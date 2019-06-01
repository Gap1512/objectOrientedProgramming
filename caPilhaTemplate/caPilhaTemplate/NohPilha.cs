using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilha
{
    class NohPilha<TAD> : Object
    {
        private TAD data;
        private NohPilha<TAD> nextNoh;

        public NohPilha()
        {
            nextNoh = null;
        }

        public NohPilha(TAD valor)
        {
            data = valor;
            nextNoh = null;
        }

        public NohPilha(TAD valor, NohPilha<TAD> noh)
        {
            data = valor;
            nextNoh = noh;
        }

        public TAD getData()
        {
            return data;
        }

        public NohPilha<TAD> getNext()
        {
            return nextNoh;
        }

        public void setData(TAD data)
        {
            this.data = data;
        }

        public void setNext(NohPilha<TAD> nextNoh)
        {
            this.nextNoh = nextNoh;
        }
    }
}
