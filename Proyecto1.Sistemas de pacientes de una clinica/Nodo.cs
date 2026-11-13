
using Proyecto_1_Cinica;

namespace Proyecto1_Clinica
{
    public class Nodo
    {
        public Paciente Datos;
        public Nodo Sigiente;

        public Nodo(Paciente pacinete)
        {
            Datos = pacinete;
            Sigiente = null;
        } 
        public Paciente Paciente { get; }
    }
}