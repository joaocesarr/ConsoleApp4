using System;
using ConsoleApp4.Exercício5;
public class Gerarforma

{
    public void SolicitarForma()
    {
        Console.WriteLine("Escolha uma forma para saber área e perimetro: ");
        Console.WriteLine("1 - Circulo");
        Console.WriteLine("2 - Quadrado");
        Console.WriteLine("3 - Hexagono");
        Console.WriteLine("4 - Triangulo");
        Console.WriteLine("5 - Sair");
        int Opcao = int.Parse(Console.ReadLine());

        if (Opcao == 1)
        {
            Console.Write("Digite o tamanho do raio: ");
            Circulo C = new Circulo();
            C.raio = double.Parse(Console.ReadLine());
            C.CalcularArea();
            C.CalcularPerimetro();
            Console.WriteLine("A área calculada é: " + C.area);
            Console.WriteLine("O perimetro calculado é" + C.perimetro);
            return;
        }
        if (Opcao == 2)
        {
            Console.Write("Digite o tamanho do lado A: ");
            quadrado Q = new quadrado();
            Q.ladoA = double.Parse(Console.ReadLine());
            Console.Write("Digite o tamanho do lado B: ");
            Q.ladoB = double.Parse(Console.ReadLine());
            Q.CalcularArea();
            Q.CalcularPerimetro();
            Console.WriteLine("A área calculada é: " + Q.area);
            Console.WriteLine("O perimetro calculado é: " + Q.perimetro);
        }
        if (Opcao == 3)
        {
            Console.WriteLine("Digite o tamanho do lado A: ");
            hexagono H = new hexagono();
            H.ladoA = double.Parse(Console.ReadLine());
            H.CalcularArea();
            H.CalcularPerimetro();
            Console.WriteLine("A área calculada é: " + H.area);
            Console.WriteLine("O perimetro calculado é: " + H.perimetro);
        }
        if (Opcao == 4)
        {
            Console.WriteLine("Digite o tamanho do lado A: ");
            triangulo T = new triangulo();
            T.ladoA = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tamanho do lado B: ");
            T.ladoB = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tamanho do lado C: ");
            T.ladoC = double.Parse(Console.ReadLine());
            T.CalcularArea();
            T.CalcularPerimetro();
            Console.WriteLine("A área calculada é: " + T.area);
            Console.WriteLine("O perimetro calculado é: " + T.perimetro);
        }
    }
}