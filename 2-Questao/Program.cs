using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Questao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 51, 53, 101, 102, 101, 51, 13, 18, 13, 51 };

            Console.WriteLine("Vetor Original");
            for (int i = 0; i < x.Length; i++)
                Console.WriteLine(x[i]);
            
            Console.WriteLine();

            Array.Sort(x);

            Console.WriteLine("Vetor Ordenado");
            for (int i = 0; i < x.Length; i++)
                Console.WriteLine(x[i]);

            Console.ReadLine();
        }
    }
}
