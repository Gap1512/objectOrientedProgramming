using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVector2D
{
    class Vetor2D
    {
        //Atributos
        //-x
        private double x;
        //-y
        private double y;
        //Metodos
        //-Construtores
        public Vetor2D()
        {
            x = .0;
            y = .0;
        }
        public Vetor2D(double _x, double _y)
        {
            x = _x;
            y = _y;
        }
        //--Getters
        public double getX()
        {
            return x;
        }
        public double getY()
        {
            return y;
        }
        //--Setters
        public void setX(double _x)
        {
            x = _x;
        }
        public void setY(double _y)
        {
            y = _y;
        }
        //---Imprimir Vetor
        public void print()
        {
            Console.WriteLine("(" + x + ", " + y + ")");
        }
        //---Produto Escalar
        public double escalar(Vetor2D _b)
        {
            return (x * _b.getX() + y * _b.getY());
        }
        //---Módulo Do Vetor
        public double modulo()
        {
            return (Math.Sqrt((x * x + y * y)));
        }
        //---Angulo Entre Vetores
        public double anguloRad(Vetor2D _b)
        {
            return (Math.Acos(this.escalar(_b) / (this.modulo() * _b.modulo())));
        }
        public double anguloDeg(Vetor2D _b)
        {
            return radDeg(this.anguloRad(_b));
        }
        //----Radianos Para Graus
        private double radDeg(double _rad)
        {
            return (_rad * (180.0 / Math.PI));
        }
        //---Projeção De Um Vetor Em Outro
       public double projecaoEm(Vetor2D _b)
        {
            return this.escalar(_b.divisaoPor(_b.modulo()));
        }
        //----Quociente Entre Vetor E Escalar
        private Vetor2D divisaoPor(double _r)
        {
            return new Vetor2D(x/_r, y/_r);
        }
    } //Fim Da Classe
}
