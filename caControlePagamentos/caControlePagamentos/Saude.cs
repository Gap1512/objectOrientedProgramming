using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caControlePagamentos
{
    class Saude : Pagtos
    {
        //Atributos
        private String estabelecimento;
        private double vlfatSaude;

        //Construtores
        public Saude() : base()
        {
            estabelecimento = "";
            vlfatSaude = .0;
        }

        public Saude(String _cpf, double _valor, int _cod)
            : base(_cpf, _valor, _cod)
        {
            estabelecimento = "";
            vlfatSaude = .0;
        }

        //Getters
        public String getEstabelecimento()
        {
            return estabelecimento;
        }

        public double getVlfatSaude()
        {
            return vlfatSaude;
        }

        //Setters
        public void setEstabelecimento(String _estabelecimento)
        {
            estabelecimento = _estabelecimento;
        }

        public void setVlfatSaude(double _vlfatSaude)
        {
            vlfatSaude = _vlfatSaude;
        }

        //Métodos
        public override void faturar()
        {
            vlfatSaude = (valor * 1.12);
            Console.WriteLine("Insira o nome do estabelecimento");
            estabelecimento = Console.ReadLine();
        }

        public override void imprimeFatura()
        {
            base.imprimeFatura();
            Console.WriteLine(
                "Saúde -> Estabelecimento: \"" + estabelecimento + "\"; Valor Fatura: R$" + 
                Math.Round(vlfatSaude, 2) + "\n");
        }

    } //Fim da classe
}
