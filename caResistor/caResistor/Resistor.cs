using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caResistor
{
    class Resistor
    {
        //Atributos
        private double resistencia, pMax;

        //Construtores
        public Resistor()
        {
            resistencia = pMax = .0;
        }

        public Resistor(double _resistencia, double _pMax)
        {
            resistencia = _resistencia;
            pMax = _pMax;
        }

        //Getters
        public double getResistencia()
        {
            return resistencia;
        }

        public double getPMax()
        {
            return pMax;
        }

        //Setters
        public void setResistencia(double _resistencia)
        {
            resistencia = _resistencia;
        }

        public void setPMax(double _pMax)
        {
            pMax = _pMax;
        }

        //Métodos
        public Resistor resistorSerie(Resistor _resistor)
        {
            return new Resistor(
                resistencia + _resistor.getResistencia(),
                (pMax < _resistor.getPMax()) ? pMax : _resistor.getPMax());
        }

        public Resistor resistorParalelo(Resistor _resistor)
        {
            return new Resistor(
                ((resistencia * _resistor.getResistencia())/(resistencia + _resistor.getResistencia())),
                (pMax < _resistor.getPMax()) ? pMax : _resistor.getPMax());
        }

        public void imprimeResistor()
        {
            Console.WriteLine(
                "Resistência: " + resistencia + "\n" +
                "Potência Máxima: " + pMax);
        }

    } //Fim da Classe
}
