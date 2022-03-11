using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Questao
{
    public class Quadrado : Figura
    {
        public double Lado { get; set; }
        public override double CalcularArea => this.Lado * this.Lado;

    }
}

       /*
        public Quadrado()
        {
            this.Altura = 0;
            this.Base = 0;
        }

        private double alturaquadrado;

        public double Altura
        {
            get { return alturaquadrado; }
            set
            {
                if (value >= 0)
                    alturaquadrado = value;
                else alturaquadrado = 0;
            }
        }

        private double basequadrado;
        public double Base
        {
            get { return basequadrado; }
            set
            {
                if (value >= 0)
                    basequadrado = value;
                else basequadrado = 0;
            }
        }

        public double Area
        {
            get
            {
                return (basequadrado * alturaquadrado);
            }
        }

        public void ExibeDados()
        {
            Console.WriteLine("Base: " + this.Base);
            Console.WriteLine("Altura " + this.Altura);
            Console.WriteLine("Area: " + this.Area);
        }
        */