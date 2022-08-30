using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_parcial
{
    internal class Mostrador : Vendedor
    {
        private readonly int sucursalNro;

        public Mostrador(string nombre, int dni, double basico,int suc) : base(nombre, dni, basico)
        {
            this.sucursalNro = suc;
        }
        public int SucursalNro
        {
            get { return sucursalNro; }
        }

        override public void AgregarVenta(double monto)
        {
            ventaTotales+=monto;
        }
        override public double Sueldo()
        {
            double comision = ventaTotales*2/100;
            if (ventaTotales > 10000 && ventaTotales < 200000)
                comision = ventaTotales * 3 / 100;
            else if(ventaTotales>200000)
                comision = ventaTotales * 5 / 100;
            return sueldoBasico + comision;
        }

        override public string ToString()
        {
            return nombre;
        }
    }
}
