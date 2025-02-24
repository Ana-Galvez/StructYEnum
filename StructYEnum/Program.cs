using System;

namespace StructYEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Empleado ana = new Empleado("Ana", 20000);
            //Console.WriteLine(ana);
            //ana.MasSalario(500);
            //Console.WriteLine(ana);
            //Empleado juan = new Empleado("Juan", 30000);
            //Console.WriteLine(juan);
            //juan = ana;
            //Console.WriteLine(juan);
            //juan.MasSalario(1200);
            //Console.WriteLine(juan);
            //Console.WriteLine(ana);
            //ana.MasSalario(100000);
            //Console.WriteLine(ana);

            //Coordenadas coordenada1 = new Coordenadas(32,14);
            //coordenada1.MostrarCoordenadas();

            ColorRGB colorRGB1 = new ColorRGB(250,125,72);
            colorRGB1.MostrarColorRGB();

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

    public struct Coordenadas
    {
        private int x;
        private int y;

        public Coordenadas(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void MostrarCoordenadas()
        {
            Console.WriteLine($"Coordenada x: {x}");
            Console.WriteLine($"Coordenada y: {y}");
        }
    }

    public struct ColorRGB
    {
        private byte rojo;
        private byte verde;
        private byte azul;

        public ColorRGB(byte rojo,byte verde, byte azul)
        {
            this.rojo = rojo;
            this.verde = verde;
            this.azul = azul;
        }

        public void MostrarColorRGB()
        {
            Console.WriteLine($"Color RGB formado por: ({rojo},{verde},{azul})");
        }
    }



}
