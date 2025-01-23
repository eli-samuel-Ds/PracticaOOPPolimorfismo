using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOOPPolimorfismo
{
    internal class EmpleadoAdministrativo : Empleado
    {
        private float _salarioFijo;
        public float SalarioFijo
        {
            get { return _salarioFijo; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("El Salario no puede ser negativo");
                }
                else
                {
                    _salarioFijo = value;
                }
            }
        }
        private float _bonificacion;
        public float Bonificacion
        {
            get { return _bonificacion; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("La Bonificacion no puede ser negativa");
                }
                else
                {
                    _bonificacion = value;
                }
            }
        }
        public bool MetaCumplida { get; set; }
        public EmpleadoAdministrativo(string nombre, string seguro, float salarioFijo, float bonificacion, bool metaCumplida)
            : base(nombre, seguro)
        {
            SalarioFijo = salarioFijo;
            MetaCumplida = metaCumplida;
            Bonificacion = bonificacion;
        }
        public override float SalarioMensual()
        {
            return MetaCumplida ? SalarioFijo + Bonificacion : SalarioFijo / 2;
        }
        public override string MostrarInformacion()
        {
            return $"Nombre: {Nombre} - Seguro: {Seguro} - Salario Mensual: {SalarioMensual()}";
        }
    }
}