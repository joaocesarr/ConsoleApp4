using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Exercício5
{
    public class quadrado : Forma
    {
        public double ladoA;
        public double ladoB;

        public override void CalcularArea()
        {
            base.CalcularArea();
            area = ladoA * ladoB;
        }
        public override void CalcularPerimetro()
        {
            base.CalcularPerimetro();
            perimetro = ladoA + ladoA + ladoB + ladoB;
        }
    }
}