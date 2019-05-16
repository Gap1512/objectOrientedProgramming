using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caControlePagamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pagtos> pagtos = new List<Pagtos>();
            double valorTeste = 1234.56;

            for(int i = 0; i < 6; i += 2)
            {
                pagtos.Add(new Alimentacao("CPFTESTEAL000", valorTeste, i));
                pagtos.Add(new Saude("CPFTESTESA000", valorTeste, i + 1));
                valorTeste *= 2.34;
            }

            foreach (Pagtos pagto in pagtos)
            {
                Console.WriteLine("Fatura do Pagamento Código " + (pagto.getCod() + 1));
                pagto.faturar();
            }

            Console.WriteLine("\nHistórico de Pagamentos\n");

            foreach (Pagtos pagto in pagtos)
            {
                pagto.imprimeFatura();
            }

            Console.ReadLine();
        }
    }
}
