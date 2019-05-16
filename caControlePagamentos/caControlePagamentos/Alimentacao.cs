using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caControlePagamentos
{
    class Alimentacao : Pagtos
    {
        //Atributos
        private String descricao;
        private double vlfatAliment;

        //Construtores
        public Alimentacao() : base()
        {
            descricao = "";
            vlfatAliment = .0;
        }

        public Alimentacao(String _cpf, Double _valor, int _cod)
            : base(_cpf, _valor, _cod)
        {
            descricao = "";
            vlfatAliment = .0;
        }

        //Getters
        public String getDescricao()
        {
            return descricao;
        }

        public double getVlfatAliment()
        {
            return vlfatAliment;
        }

        //Setters
        public void setDescricao(String _descricao)
        {
            descricao = _descricao;
        }

        public void setVlfatAliment(double _vlfatAliment)
        {
            vlfatAliment = _vlfatAliment;
        }

        //Métodos
        public override void faturar()
        {
            vlfatAliment = (valor * 1.05);
            Console.WriteLine("Insira a descrição do item adquirido");
            descricao = Console.ReadLine();
        }

        public override void imprimeFatura()
        {
            base.imprimeFatura();
            Console.WriteLine(
                "Alimentação -> Descrição: \"" + descricao + "\"; Valor Fatura: R$" + 
                Math.Round(vlfatAliment, 2) + "\n");
        }

    } //Fim da classe
}
