using Proyecto_1_Cinica;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Proyecto1_Clinica
{
    internal class Program
    {
        static Cola pacintes= new Cola();

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();

                Console.WriteLine("=====CLINICA=====");
                Console.WriteLine("1.Registrar pacientes");
                Console.WriteLine("2.Atender pacientes");
                Console.WriteLine("3.Mostrar pacientes");
                Console.WriteLine("0.Salir");
                Console.WriteLine("Opcion");

                opcion = int .Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Registrar();
                        break;

                    case 2:
                        Atender();
                        break;

                    case 3:
                        pacintes.Mostrar();
                        Console.ReadKey();
                        break;
                }
            }
            while (opcion != 0);
        }

        static void Registrar()
        {
            Console.WriteLine("Expediente: ");
            int expediente = int.Parse(Console.ReadLine());

            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Prioridad: ");
            int prioridad = int.Parse(Console.ReadLine());

            Paciente paciente = new Paciente(expediente, nombre, edad, prioridad);

            pacintes.Encolar(paciente);

            Console.WriteLine("Pacinete registrado.");
            Console.ReadKey();
        }

        static void Atender()
        {
            Paciente paciente = pacintes.Desencolar();

            if (paciente == null)
                Console.WriteLine();


            if (paciente == null)
                Console.WriteLine(paciente);
            Console.ReadKey();
        }
    }
}