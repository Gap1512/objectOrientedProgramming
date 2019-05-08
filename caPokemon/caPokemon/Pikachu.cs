using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPokemon
{
    class Pikachu : Pokemon
    {
        public Pikachu() : base()
        {

        }

        public override void emiteSom()
        {
            Console.WriteLine("pikapi!\n");
        }
    }
}
