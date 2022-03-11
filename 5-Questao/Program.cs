using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Questao
{
    internal class Program
    {
        static Boolean Empilhar(int[] pilha, ref int topo, int dado)
        {
            Boolean retorno = false;

            if (topo < 5)
            {
                pilha[topo] = dado;
                topo = topo + 1;
                retorno = true;
            }
            return retorno;
        }

        static Boolean Desempilhar(int[] pilha, ref int topo, int dado)
        {
            Boolean retorno = false;

            if (topo > 0)
            {
                topo = topo - 1;
                dado = pilha[topo];
                retorno = true;
            }
            return retorno;
        }

        static void ExibirDados(int[] pilha, int topo)
        {
            for (int i = topo; i >= 0; i--)
            {
                Console.WriteLine(pilha[i]);
            }
        }

        static void Main(string[] args)
        {
            int[] pilha = new int[5];
            int topo = 0;
            int valor = 0 ;

            Empilhar(pilha, ref topo, 20);
            Empilhar(pilha, ref topo, 15);
            Empilhar(pilha, ref topo, 10);
            Empilhar(pilha, ref topo, 40);

            Desempilhar(pilha, ref topo, valor);
            ExibirDados(pilha, topo);
            Console.ReadLine();
        }
    }
}
