using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilha
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha = new Pilha();

            pilha.push(3);
            pilha.push(5);
            pilha.push(8);
            pilha.print();

            Console.ReadLine();
        }
    }
}
