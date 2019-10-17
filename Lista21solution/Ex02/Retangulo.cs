using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Retangulo
    {
        private double b, h;

        public void SetBase(double b)
        {
            if (b > 0) this.b = b;
            else throw new ArgumentOutOfRangeException();
        }

        public void SetAltura(double h)
        {
            if (h > 0) this.h = h;
            else throw new ArgumentOutOfRangeException();
        }

        public double GetBase()
        {
            return b;
        }

        public double GetAltura()
        {
            return h;
        }

        public double CalcArea()
        {
            return h * b;
        }

    }
}
