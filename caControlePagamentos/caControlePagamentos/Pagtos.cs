using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caControlePagamentos
{
    class Pagtos
    {
        //Atributos
        protected String cpf;
        protected double valor;
        protected int cod;

        //Construtores
        public Pagtos()
        {
            cpf = "";
            valor = .0;
            cod = 0;
        }

        public Pagtos(String _cpf, double _valor, int _cod)
        {
            cpf = _cpf;
            valor = _valor;
            cod = _cod;
        }

        //Getters
        public String getCpf()
        {
            return cpf;
        }

        public double getValor()
        {
            return valor;
        }

        public int getCod()
        {
            return cod;
        }

        //Setters
        public void setCpf(String _cpf)
        {
            cpf = _cpf;
        }

        public void setValor(double _valor)
        {
            valor = _valor;
        }

        public void setCod(int _cod)
        {
            cod = _cod;
        }

        //Método
        public virtual void faturar() { }

        public virtual void imprimeFatura()
        {
            Console.WriteLine(
                "Pagamento Nº" + (cod + 1) + " Valor Inicial: R$" + Math.Round(valor, 2) + " CPF: " + cpf);
        }

    } //Fim da classe
}
