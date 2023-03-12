using System;

namespace Figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = 7;
             // Rectángulo
            double b = 3 * L;
            double h = L; 
            double areaRect = b * h;
            double perimetroRect = 2 * (b + h);

            // Triángulos
            double catetoT = 1 * L;
            double hipotenusaT = Math.Sqrt(Math.Pow(catetoT, 2) + Math.Pow(3 * L, 2));
            double areaTriangulo = (catetoT * (3 * L)) / 2;
            double perimetroTriangulo = (2 * (3 * L))+ hipotenusaT;


            // Medio círculo
            double radio = 3 * L / 2;
            double areaMC = Math.PI * Math.Pow(radio, 2) / 2;
            double perimetroMC = Math.PI * radio;

            // Total
            double areaTotal = (areaRect *2)+(areaTriangulo *2) + areaMC;
            double perimetroTotal = (perimetroRect - L) + (hipotenusaT * 2)  + perimetroMC;
            Console.WriteLine("Área total: " + areaTotal);
            Console.WriteLine("Perímetro total: " + perimetroTotal);
        }
    }
}
