using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Questao
{
    public class Triangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public override double CalcularArea => (this.Base * this.Altura) / 2;
    }
}



        /*
        public Triangulo()
        {
            this.Altura = 0;
            this.Base = 0;
        }

        private double basetriangulo;

        public double Base
        {
            get { return basetriangulo; }
            set {
                if (value >= 0)
                    basetriangulo = value;
                else basetriangulo = 0;
            }
        }


        private double alttriangulo;
        public double Altura
        {
            get { return alttriangulo; }
            set {
                if (value >= 0) alttriangulo = value;
                else alttriangulo = 0;
            }
        }

        public double Area
        {
            get { 
                return (alttriangulo * basetriangulo) / 2.0;
            }
        }

        public void ExibeDados()
        {
            Console.WriteLine("Base: " + this.Base);
            Console.WriteLine("Altura: " + this.Altura);
            Console.WriteLine("Area: " + this.Area);
        }
        */