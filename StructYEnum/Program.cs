using System;

namespace StructYEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado ana = new Empleado("Ana", 20000);
            Console.WriteLine(ana);
            ana.MasSalario(500);
            Console.WriteLine(ana);
            Empleado juan = new Empleado("Juan", 30000);
            Console.WriteLine(juan);
            juan = ana;
            Console.WriteLine(juan);
            juan.MasSalario(1200);
            Console.WriteLine(juan);
            Console.WriteLine(ana);
            ana.MasSalario(100000);
            Console.WriteLine(ana);


        }
    }

    public struct Empleado
    {
        private string nombre;
        private double salario;

        public Empleado(string nombre, double salario)
        {
            this.nombre = nombre;
            this.salario = salario;
        }

        public override string ToString()
        {
            return $"Nombre del empleado: {nombre} y su salario es: {salario}";
        }

        public void MasSalario(double incremento)
        {
            salario+=incremento;
        }
    }


}
