using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _01_DeclaracaoClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado obj1 = new Quadrado();
            obj1.Lado = 5;
            obj1.ImprimeArea();

            obj1.Lado = 15;
            obj1.ImprimeArea();

            Quadrado obj2 = new Quadrado();
            obj2.Lado = 25;
            obj2.ImprimeArea();

            Retangulo obj3 = new Retangulo();
            obj3.Largura = 15;
            obj3.Altura = 5;
            obj3.ImprimeArea();

            Circulo obj4 = new Circulo();
            obj4.Raio = 7.5;
            obj4.ImprimeArea();

            Triangulo obj5 = new Triangulo();
            obj5.Altura = 25.5;
            obj5.Base = 12.75;
            obj5.ImprimeArea();

        }
    }

    public class Quadrado
    {
        public int Lado;

        public int CalculaArea()
        {
            int area = Lado * Lado;
            return area;
        }

        public void ImprimeArea()
        {
            Console.WriteLine($"Quadrado com lado de {Lado} possui uma área de {CalculaArea()}");
        }
    }

    public class Retangulo
    {
        public int Largura, Altura;

        public int CalculaArea()
        {
            return Largura * Altura;
        }

        public void ImprimeArea()
        {
            Console.WriteLine($"Retângulo com largura de {Largura}, altura de {Altura} possui uma área de {CalculaArea()}");
        }

    }

    public class Circulo
    {
        public double Raio;

        public double CalculaArea()
        {
            return Math.Pow(Raio, 2) * Math.PI;
        }

        public void ImprimeArea()
        {
            Console.WriteLine($"Círculo com raio de {Raio:N2} possui uma área de {CalculaArea():N2}");
        }
    }

    public class Triangulo
    {
        public double Base, Altura;

        public double CalculaArea()
        {
            return Base * Altura / 2;
        }

        public void ImprimeArea()
        {
            Console.WriteLine($"Triângulo com base de {Base:N2}, altura de {Altura:N2} possui uma área de {CalculaArea():N2}");

        }
    }

}
