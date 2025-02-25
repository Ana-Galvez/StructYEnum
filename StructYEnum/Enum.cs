using System;

namespace StructYEnum
{
    enum Estaciones { Otoño, Invierno, Primavera, Verano };

    enum Bonus { Bajo=500,Normal=1000,Alto=1500,Muy_Alto=3000};

    class Empleado1
    {
        private double salario, bonus;
        private string nombre;
        public Empleado1(string nombre,double salario, Bonus bonus)
        {
            this.bonus = (double)bonus;
            this.salario = salario;
            this.nombre = nombre;
        }

        //public void GetEmpleado()
        //{
        //    double totalACobrar = salario + bonus;
        //    Console.WriteLine($"El empleado {nombre} cobra actualmente {totalACobrar}");
        //}

        public double GetSalarioTotal()
        {
            return salario + bonus;
        }
    }

}
