using Proyecto_2_Restaurante;
using System;

namespace Proyecto_2_Restaurante
{
    internal class Nodo
    {
        public Cliente Dato;
        public Nodo Siguiente;
        public Nodo(Cliente cliente)
        {
            Dato = cliente;
            Siguiente = null;
        }
    }
}