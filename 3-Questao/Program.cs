using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Questao
{
    internal class Program
    {
        public enum OpcoesMenu
        {
            Sair = 0, Quadrado = 1, Triangulo = 2, Circulo = 3
        }

        static void Main(string[] args)
        {
            OpcoesMenu escolha = OpcoesMenu.Quadrado;
            while ((escolha = GetEscolha()) != OpcoesMenu.Sair)
            {
                Figura forma = null;
                switch (escolha)
                {
                    case OpcoesMenu.Quadrado:
                        forma = CriaQuadrado();
                        break;
                    case OpcoesMenu.Triangulo:
                        forma = CriaTriangulo();
                        break;
                    case OpcoesMenu.Circulo:
                        forma = CriaCirculo();
                        break;
                    default:
                        break;
                }
                Console.WriteLine($"A área do {escolha} é {forma.CalcularArea}");
                Console.WriteLine();
            }
            Console.ReadLine();

        }

        public static OpcoesMenu GetEscolha()
        {
            Console.WriteLine("Escolha a figura para qual deseja calcular a Área: ");
            Console.WriteLine("\t{0} - Quadrado", (int)OpcoesMenu.Quadrado);
            Console.WriteLine("\t{0} - Triangulo", (int)OpcoesMenu.Triangulo);
            Console.WriteLine("\t{0} - Circulo", (int)OpcoesMenu.Circulo);
            Console.WriteLine("\t{0} - Sair", (int)OpcoesMenu.Sair);
            Console.Write("Escolha: ");
            string valor = Console.ReadLine();
            OpcoesMenu escolha;
            if (!Enum.TryParse(valor, out escolha) || !Enum.IsDefined(typeof(OpcoesMenu), escolha))
            {
                Console.WriteLine("Opção inválida, Escolha uma Opção Válida.");
                return GetEscolha();
            }
            return escolha;
        }

        private static double GetDouble(string prompt)
        {
            bool isValido = false;
            double valor = 0;
            while (!isValido)
            {
                isValido = double.TryParse(Console.ReadLine(), out valor);
            }
            return valor;
        }

        private static Quadrado CriaQuadrado()
        {
            double lado = GetDouble("Lado do Quadrado : ");
            return new Quadrado()
            {
                Lado = lado
            };

        }

        private static Triangulo CriaTriangulo()
        {
            double valorBase = GetDouble("Valor da Base : ");
            double altura = GetDouble("Valor da Altura : ");
            return new Triangulo()
            {
                Base = valorBase,
                Altura = altura
            };

        }
        private static Circulo CriaCirculo()
        {
            double raio = GetDouble("Valor do Raio : ");
            return new Circulo()
            {
                Raio = raio
            };

        }
    }
}
        
        
        
  /*
  * var formasGeometricas = new List<figura> { "quadrado", "triângulo equilatero", "circulo"};
  * Criar uma classe abstrata figura, colocar os metodos 
    */

/*
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
*/