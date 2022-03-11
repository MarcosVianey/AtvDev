using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Questao
{
    public class Circulo : Figura
    {
        public double Raio { get; set; }
        public override double CalcularArea => Math.Pow(this.Raio, 2) * Math.PI;
    }
} 

/*
    public Circulo()
    {
        this.Raio = 0;
    }

    private double raiocirculo;

    public double Raio
    {
        get { return raiocirculo; }
        set
        {
            if (value >= 0)
                raiocirculo = value;
            else raiocirculo = 0;
        }
    }

    public double Area
    {
        get
        {
            return (3.14 * (Math.Pow(raiocirculo,2)));
        }
    }

    public void ExibeDados()
    {
        Console.WriteLine("Raio: " + this.Raio);
        Console.WriteLine("Area: " + this.Area);
    }
    */