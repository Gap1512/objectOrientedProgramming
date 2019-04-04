using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEstacionamentoTempo
{
    class Estacionamento
    {
        //Atributos
        List<Carro> carros;
        //-----------------------------------------------------------------
        //Métodos
        //-----------------------------------------------------------------
        //-Construtores
        public Estacionamento()
        {
            carros = new List<Carro>();
        }
        //-----------------------------------------------------------------
        //-Getters
        public List<Carro> getCarros()
        {
            return carros;
        }
        //-----------------------------------------------------------------
        //Outros Métodos
        public void novaEntrada()
        {
            String _chapa, _marca;
            Tempo _entrada = new Tempo();
            Tempo _saida = new Tempo();

            Console.WriteLine("Insira a chapa do carro: ");
            _chapa = Console.ReadLine();
            Console.WriteLine("Insira a marca do carro: ");
            _marca = Console.ReadLine();
            Console.WriteLine("Insira as informações de entrada");
            _entrada.solicitaDados();
            Console.WriteLine("Insira as informações de saída");
            _saida.solicitaDados();

            carros.Add(new Carro(_chapa, _marca, _entrada, _saida));
        }

        public void relatorio()
        {
            Console.WriteLine("\nCarros cadastrados\n");

            for (int i = 0; i < carros.Count(); i++)
            {
                Console.WriteLine("Carro " + (i + 1));
                carros[i].print();
                valorTotal(carros[i]);
                Console.WriteLine();
            }
        }

        public Carro procuraCarro()
        {
            Carro _carro = null;

            relatorio();

            do
            {
                Console.WriteLine("\nInsira a chapa do carro");
                String _chapa = Console.ReadLine();
                for (int i = 0; i < carros.Count(); i++)
                {
                    if (carros[i].getChapa() == _chapa)
                    {
                        _carro = carros[i];
                    }
                }
            } while (_carro == null);

            return _carro;
        }

        public void valorTotal(Carro _carro)
        {
            int _hora = _carro.getSaida().subtrai(_carro.getEntrada()).getHora();

            Console.WriteLine("Valor a pagar: R$" + (_hora * 7.0));
        }

        public void novaSaida()
        {
            Carro aux;
            aux = procuraCarro();
            carros.Remove(aux);
        }
        //-----------------------------------------------------------------
    } //Fim da Classe
}
