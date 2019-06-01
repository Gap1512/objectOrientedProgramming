using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caFila
{
    class NoFila<ADT> : Object
    {
        private ADT info;
        private NoFila<ADT> next;

        public NoFila()
        {
            next = null;
        }

        public NoFila(ADT info)
        {
            this.info = info;
            next = null;
        }

        public NoFila(ADT info, NoFila<ADT> next)
        {
            this.info = info;
            this.next = next;
        }

        public ADT getInfo()
        {
            return info;
        }

        public NoFila<ADT> getNext()
        {
            return next;
        }

        public void setInfo(ADT info)
        {
            this.info = info;
        }

        public void setNext(NoFila<ADT> next)
        {
            this.next = next;
        }
    }
}
