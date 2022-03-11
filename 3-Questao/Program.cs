using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Questao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var formasGeometricas = new List<string> { "quadrado", "triângulo equilatero", "circulo"};

            Console.WriteLine("####CIRCULO#####");
            Circulo circulo = new Circulo();
            Console.WriteLine("Calcular a área de um circulo: ");
            Console.Write("Informe o raio: ");
            circulo.Raio = Convert.ToDouble(Console.ReadLine());

            circulo.ExibeDados();

            Console.WriteLine();

            Console.WriteLine("####TRIANGULO#####");
            Triangulo triangulo = new Triangulo();
            Console.WriteLine("Calcular a area de um triangulo: ");
            Console.Write("Informe a altura: ");
            triangulo.Altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a Base: ");
            triangulo.Base = Convert.ToDouble(Console.ReadLine());

            triangulo.ExibeDados();

            Console.WriteLine();

            Console.WriteLine("####QUADRADO#####");
            Quadrado quadrado = new Quadrado();
            Console.WriteLine("Calcular a área de um quadrado: ");
            Console.Write("Informe a altura: ");
            quadrado.Altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o valor da base: ");
            quadrado.Base = Convert.ToDouble(Console.ReadLine());

            quadrado.ExibeDados();

            Console.ReadLine();
        }
    }
}
