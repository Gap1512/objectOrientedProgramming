using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVeiculos
{
    class Automovel : Veiculo
    {
        private int qte_rodas;
        //{
        //    get { return qte_rodas; }
        //    set { qte_rodas = value; }
        //}

        public Automovel(String _tipo, int _qte_rodas) : base(_tipo)
        {
            qte_rodas = _qte_rodas;
        }

        public int getRodas()
        {
            return qte_rodas;
        }

        public void setRodas(int _qte_rodas)
        {
            qte_rodas = _qte_rodas;
        }

        public override void mover()
        {
            Console.WriteLine("Acelerando o automóvel");
        }

        public override void parar()
        {
            Console.WriteLine("Brecando o automóvel");
        }
    }
}
