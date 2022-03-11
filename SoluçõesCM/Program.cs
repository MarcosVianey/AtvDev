using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Questao

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 51, 53, 101, 102, 101, 51, 13, 18, 13, 51};

            Dictionary<int, int> counts = new Dictionary<int, int>();
            
            foreach (int a in x)
            {
                if (counts.ContainsKey(a))
                    counts[a] = counts[a] + 1;
                else
                    counts[a] = 1;
            }

            int result = int.MinValue;
            int max = int.MinValue;
            foreach (int key in counts.Keys)
            {
                if (counts[key] > result)
                {
                    max = counts[key];
                    result = key;
                }
            }

            Console.WriteLine("A moda é: " + result);

            Console.ReadLine();
        }
    }
}
