using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOOPPolimorfismo
{
    internal class DocenteFijo : Empleado
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
        public bool MetaCumplida { get; set; }
        public DocenteFijo(string nombre, string seguro,float salarioFijo, bool metaCumplida) 
            : base(nombre, seguro)
        {
            SalarioFijo = salarioFijo;
            MetaCumplida = metaCumplida;
        }
        public override float SalarioMensual()
        {
            return MetaCumplida ? SalarioFijo : SalarioFijo / 2;
        }
        public override string MostrarInformacion()
        {
            return $"Nombre: {Nombre} - Seguro: {Seguro} - Salario Mensual: {SalarioMensual()}";
        }
    }
}
