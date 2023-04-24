using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.Exercício5;

namespace ConsoleApp4.Exercício5
{
    public class triangulo : Forma
    {
        public double ladoA;
        public double ladoB;
        public double ladoC;
        public override void CalcularArea()
        {
            base.CalcularArea();
            double p = (ladoA + ladoB + ladoC) / 2;
            area = Math.Sqrt(p * (p - ladoA) * (p - ladoB) * (p - ladoC));
        }
        public override void CalcularPerimetro()
        {
            base.CalcularPerimetro();
            perimetro = ladoA + ladoB + ladoC;

        }
    }


}