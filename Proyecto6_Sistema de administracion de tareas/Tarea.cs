//Lista simplemaente enlazada y lista doblemente enlazada
//Desarollar un administrador de tareas similar a una aplicacion de productividad

//Cada tarea tendra:
//ID
//Prioridad
//Fecha
//Estado
//Responsable

//Funciones:
//Agregar tarea
//Eliminar tarea 
//Buscar tarea
//Modificar tarea
//Marcar como terminada
//Mostrar tareas pendientes
//Mostrar tareas terminadas
//Ordenar tareas
using System;

namespace Proyecto6_Tareas
{
    public class Tarea
    {
        public int id {  get; set; }
        public string Descripcion { get; set; }
        public string Estado {  get; set; }

        public Tarea(int id, string descripcion)
        {
            id = id;
            Descripcion = descripcion;
            Estado = "Pendiente";
        }

        public override string ToString()
        {
            return $"{id} - {Descripcion} - {Estado}";
        }
    }
}