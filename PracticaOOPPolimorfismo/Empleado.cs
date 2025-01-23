using System;

namespace PracticaOOPPolimorfismo
{
    abstract class Empleado
    {
        public string Nombre { get; set; }
        public string Seguro { get; set; }
        public Empleado(string nombre, string seguro)
        {
            Nombre = nombre;
            Seguro = seguro;
        }
        public abstract float SalarioMensual();
        public abstract string MostrarInformacion();
    }
}
