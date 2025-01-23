using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOOPPolimorfismo
{
    internal class DocenteHora : Empleado
    {
        private int _horasTrabajadas;
        public int HorasTrabajadas
        {
            get { return _horasTrabajadas; }
            set
            {
                if (value > 1)
                    _horasTrabajadas = value;
                else
                {
                    throw new ArgumentException("El Valor no puede ser menor que 1");
                }
            }
        }
        public float TarifaPorHora { get; set; } = 800;
        public DocenteHora(string nombre, string seguro, int horasTrabajadas) 
            : base(nombre, seguro)
        {
            HorasTrabajadas = horasTrabajadas;
        }

        public override float SalarioMensual()
        {
            return HorasTrabajadas * TarifaPorHora;
        }

        public override string MostrarInformacion()
        {
            return $"Nombre: {Nombre} - Seguro: {Seguro} - Salario Mensual: {SalarioMensual()}";
        }
    }
}
