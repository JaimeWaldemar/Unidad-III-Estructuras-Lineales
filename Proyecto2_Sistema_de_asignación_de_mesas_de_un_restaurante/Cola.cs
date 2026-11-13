using Proyecto_2_Restaurante;
using System;
using System.Collections.Generic;

namespace Proyecto_2_Restaurante
{
    public class Cola
    {
        private Nodo frente;
        private Nodo final;

        public Cola()
        {
            frente = null;
            final = null;
        }

        public void Encolar(Cliente cliente)
        {
            Nodo nuevo = new Nodo(cliente);

            if (final == null)
            {
                frente = nuevo;
                final = nuevo;
            }
            else
            {
                final.Siguiente = nuevo;
                final = nuevo;
            }
        }

        public Cliente Desencolar()
        {
            if (frente == null)
                return null;

            Cliente cliente = frente.Dato;
            frente = frente.Siguiente;

            if (frente == null)
                final = null;
            return cliente;
        }

        public void Mostrar()
        {
            Nodo actual = frente;

            while (actual != null)
            {
                System.Console.WriteLine(actual.Dato);
                actual = actual.Siguiente;
            }
        }
    }
}
