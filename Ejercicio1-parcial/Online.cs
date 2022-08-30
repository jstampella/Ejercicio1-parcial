using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_parcial
{
    internal class Online : Vendedor
    {
        private int totalVentas;
        private readonly string turno;

        public Online(string nom,int dni, double basico, string turno):base(nom,dni, basico)
        {
            this.turno = turno;
        }
        public string Turno
        {
            get { return turno; }
        }

        override public void AgregarVenta(double monto)
        {
            totalVentas++;
            ventaTotales+= monto;
        }
        override public double Sueldo()
        {
            double comision = ventaTotales * 1.5 / 100;
            return sueldoBasico + comision;
        }

        override public string ToString()
        {
            return nombre;
        }

        public double Promedio()
        {
            return ventaTotales / totalVentas;
        }
    }
}
