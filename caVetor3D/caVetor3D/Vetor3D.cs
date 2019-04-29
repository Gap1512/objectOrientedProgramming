using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using caVector2D;

namespace caVetor3D
{
    class Vetor3D : Vetor2D
    {
        private double z;

        public Vetor3D() : base()
        {
            z = .0;
        }

        public Vetor3D(double _x, double _y, double _z) : base(_x, _y)
        {
            z = _z;
        }

        public double getZ()
        {
            return z;
        }

        public void setZ(double _z)
        {
            z = _z;
        }

        public Vetor3D vetorial(Vetor3D _b)
        {
            return new Vetor3D(
                (y * _b.getZ() - z * _b.getY()),
                (z * _b.getX() - x * _b.getZ()),
                (x * _b.getY() - y * _b.getX()));
        }

        public override double modulo()
        {
            return (Math.Sqrt((x * x + y * y + z * z)));
        }

        public override string print()
        {
            return "(" + x + ", " + y + ", " + z + ")";
        }
    }
}
