using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_parcial
{
    public abstract class Vendedor
    {
        protected readonly string nombre;
        private readonly int dni;

        protected double sueldoBasico;
        protected double ventaTotales;

        public Vendedor(string nombre,int dni, double basico)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.sueldoBasico = basico;
        }
        public int Dni
        {
            get { return dni; }
        }

        override public abstract string ToString();

        public abstract double Sueldo();

        public abstract void AgregarVenta(double monto);
    }
}
