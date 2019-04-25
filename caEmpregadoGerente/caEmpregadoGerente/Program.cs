using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEmpregadoGerente
{
    class Program
    {
        static void Main(string[] args)
        {
            Empregado e1 = new Empregado("João", "Contabilidade", 1000.0);
            Gerente g1 = new Gerente("José", "Almoxarifado", 1000.0, "Maria");

            Console.WriteLine("Antes da alteração salarial");

            Console.WriteLine("Empregado 1: " + e1.getNome() + ", " + e1.getSecao() + ", " + e1.getSalario());
            Console.WriteLine("Gerente 1: " + g1.getNome() + ", " + g1.getSecao() + ", " + g1.getSalario() + ", " + g1.getSecretaria());

            e1.aumentaSalario(30.0);
            g1.aumentaSalario(30.0);

            Console.WriteLine("\nDepois da alteração salarial");

            Console.WriteLine("Empregado 1: " + e1.getNome() + ", " + e1.getSecao() + ", " + e1.getSalario());
            Console.WriteLine("Gerente 1: " + g1.getNome() + ", " + g1.getSecao() + ", " + g1.getSalario() + ", " + g1.getSecretaria());

            Console.ReadLine();
        }
    }
}
