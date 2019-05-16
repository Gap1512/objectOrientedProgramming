using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEmpregados
{
    class Program
    {
        static void Main(string[] args)
        {
            Empregado e1 = new Empregado();
            Empregado e2 = new Empregado("Teste 1", "Teste 1", "CPF 1");
            EmpregadoCLT eclt1 = new EmpregadoCLT();
            EmpregadoCLT eclt2 = new EmpregadoCLT("Teste 2", "Teste 2", "CPF 2", 1000);
            EmpregadoHORISTA eh1 = new EmpregadoHORISTA();
            EmpregadoHORISTA eh2 = new EmpregadoHORISTA("Teste 3", "Teste 3", "CPF 3", 10, 30);

            Console.WriteLine(
                "Salário Líquido Empregado CLT: " + eclt2.getSalLiquido() + "\n" +
                "Salário Líquido Empregado Horista: " + eh2.getSalLiquido());

            Console.ReadLine();
        }
    }
}
