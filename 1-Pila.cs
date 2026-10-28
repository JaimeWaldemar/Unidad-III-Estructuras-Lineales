//Pilas
using System;

namespace Proyecto3_Llamada
{
    public class Pila
    {
        private Nodo tope;

        private class Nodo
        {
            public string Datos;
            public Nodo Siguiente;
            public Nodo(string datos)
            {
                Datos = datos;
            }
        }
        public void Apilar(string llamada)
        {
            Nodo nuevo = new Nodo(llamada);

            nuevo.Siguiente = tope;
            tope = nuevo;
        }

        public string Desapilar()
        {
            if (tope == null)
                return null;

            string llamada = tope.Datos;
            tope = tope.Siguiente;
            return llamada;
        }

        public void Mostrar()
        {
            Nodo actuar = tope;

            while (actuar != null)
            {
                Console.WriteLine(actuar.Datos);
                actuar = actuar.Siguiente;
            }
        }
    }
}