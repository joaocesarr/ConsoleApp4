using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Exercício5
{
    public class Circulo : Forma
    {
        public double raio;
        public override void CalcularPerimetro()
        {
            base.CalcularPerimetro();
            perimetro = 2 * Math.PI * raio;
        }
        public override void CalcularArea()
        {
            base.CalcularArea();
            area = Math.PI * (raio * raio);
        }
    }

}