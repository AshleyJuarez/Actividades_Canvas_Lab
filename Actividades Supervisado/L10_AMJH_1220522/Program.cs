using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace L10_AMJH_1220522
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LAB TS 10");
            Console.WriteLine("Ingrese radio del círculo");
            double radioIngresado = double.Parse(Console.ReadLine());

            //Declaración de variables para almacenar los cálculos
            double areaCalculada = 0;
            double perimetroCalculado = 0;
            double volumenCalculado = 0;

            //Objeto de tipo Círculo
            Circulo objCirculo = new Circulo(radioIngresado);

            //Guardar los cálculos
            objCirculo.CalcularGeometria(ref perimetroCalculado, ref areaCalculada, ref volumenCalculado);

            Console.WriteLine("Perimetro: " + perimetroCalculado);
            Console.WriteLine("Area: " + areaCalculada);
            Console.WriteLine("Volumen: " + volumenCalculado);

            Console.ReadKey();

            Console.WriteLine("");
            //Solicitar cateto y angulo opuesto del triangulo
            Console.WriteLine("Ingrese longitud del cateto del triángulo: ");
            double catetoA = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los grados del ángulo opuesto del triángulo: ");
            double anguloOpuestoA = double.Parse(Console.ReadLine());

            TrianguloRectangulo objTriangulo = new TrianguloRectangulo(catetoA, anguloOpuestoA);

            //Guardar los cálculos
            double catetoA_ = objTriangulo.ObtenerCatetoA();
            double catetoB = objTriangulo.ObtenerCatetoB();
            double hipotenusa = objTriangulo.ObtenerHipotenusa();
            double anguloOpuestoA_ = objTriangulo.ObtenerAnguloOpuestoA();
            double anguloOpuestoB = objTriangulo.ObtenerAnguloOpuestoB();
            double area = objTriangulo.ObtenerArea();

            //Mostrar datos
            Console.WriteLine("Valor de cateto A: " + catetoA_);
            Console.WriteLine("Valor de cateto B: " + catetoB);
            Console.WriteLine("Valor de hipotenusa: " + hipotenusa);
            Console.WriteLine("Valor angulo opuesto A: " + anguloOpuestoA_);
            Console.WriteLine("Valor angulo opuesto B: " + anguloOpuestoB);
            Console.WriteLine("Valor de área: " + area);

            Console.ReadKey();

        }
    }
    class Circulo
    {
        private double radio;
        public Circulo (double Radio)
        {
            radio = Radio;
        }
        private double ObtenerPerimetro()
        {
            double perimetro = 2 * Math.PI * radio;
            return perimetro;
        }
        private double ObtenerArea()
        {
            double area = Math.PI * Math.Pow(radio, 2);
            return area;
        }
        private double ObtenerVolumen()
        {
            double volumen = (4 * Math.PI * Math.Pow(radio, 3)) / 3;
            return volumen;
        }
        public void CalcularGeometria(ref double unPerimetro, ref double unArea, ref double unVolumen)
        {
            unPerimetro = ObtenerPerimetro();
            unArea = ObtenerArea();
            unVolumen = ObtenerVolumen();
        }
        
    }

    class TrianguloRectangulo 
    {
        private double catetoA;
        private double anguloOpuestoA;

        public TrianguloRectangulo(double CatetoA, double AnguloOpuestoA) 
        {
            catetoA = CatetoA;
            anguloOpuestoA = AnguloOpuestoA;
        }

        public double ObtenerCatetoA()
        {
            return Math.Round(catetoA, 3);
        }

        public double ObtenerCatetoB() 
        {
            double angulo = anguloOpuestoA * Math.PI / 180;
            double catetoB = catetoA / Math.Tan(angulo);
            return Math.Round(catetoB,3);
        }

        public double ObtenerHipotenusa() 
        {
            double angulo = anguloOpuestoA * Math.PI / 180;
            double hipotenusa = ObtenerCatetoB() / Math.Cos(angulo);
            return Math.Round(hipotenusa, 3);
        }

        public double ObtenerAnguloOpuestoA()
        {
            return Math.Round(anguloOpuestoA, 3);
        }

        public double ObtenerAnguloOpuestoB() 
        {
            double anguloOpuestoB = 90 - anguloOpuestoA;
            return Math.Round(anguloOpuestoB, 3);
        }

        public double ObtenerArea() 
        {
            double area = (catetoA * ObtenerCatetoB()) / 2;
            return Math.Round(area, 3);
        }

    }
    
}
