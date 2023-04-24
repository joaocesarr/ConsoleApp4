using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Exercício5
{
    public class Forma
    {
        public double area;
        public double perimetro;
        public virtual void CalcularArea() { }
        public virtual void CalcularPerimetro() { }

    }
}