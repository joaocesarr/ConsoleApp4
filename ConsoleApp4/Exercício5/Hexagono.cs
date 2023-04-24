using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Exercício5
{
    public class hexagono : Forma
    {
        public double ladoA;
        public override void CalcularArea()
        {
            base.CalcularArea();
            area = (3 * (ladoA * ladoA) * Math.Sqrt(3)) / 2;
        }
        public override void CalcularPerimetro()
        {
            base.CalcularPerimetro();
            perimetro = 6 * ladoA;
        }
    }
}
