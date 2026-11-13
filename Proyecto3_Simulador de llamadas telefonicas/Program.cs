using Proyecto3_Llamada;
using System;
namespace Proyecto3_llamada
{
    internal class Program
    {
        static Pila llamadas = new Pila();
        static void Main()
        {
            int opcion;
            do
            {
                Console.WriteLine("===SIMULADOR DE LLAMADAS===");
                Console.WriteLine("1. Registrar llamada");
                Console.WriteLine("2. Borrar");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("0. Salir¨\n");

                Console.WriteLine("Opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Nombre: ");
                        llamadas.Apilar(Console.ReadLine());
                        break;

                    case 2:
                        string llamada = llamadas.Desapilar();

                        Console.WriteLine(llamada == null ? "No existen llamadas." : $"Regresando de {llamada}");
                        Console.ReadKey();
                        break;

                    case 3:
                        llamadas.Mostrar();
                        Console.ReadKey();
                        break;
                }
            }
            while (opcion != 0);
        }
    }
}