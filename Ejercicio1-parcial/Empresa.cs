using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_parcial
{
    internal class Empresa
    {
        private int cantidadVendedores;
        private double facturacionTotal;
        private Vendedor[] vendedores;

        public Empresa(int cantVen)
        {
            this.cantidadVendedores = cantVen;
            this.vendedores = new Vendedor[cantVen];
        }

        public int CantidadVendedores
        {
            get { return cantidadVendedores; }
        }
        public double FacturacionTotal
        {
            get { return facturacionTotal; }
        }

        public void CrearLista()
        {
            vendedores[0] = new Online("pedro albornoz",232323, 62500, "tarde");
            vendedores[1] = new Online("carlos perez",11111, 62500, "noche");
            vendedores[2] = new Mostrador("roberto sanchez", 22222, 80000, 1);
            vendedores[3] = new Mostrador("Victoria lopez", 54858, 78000, 2);
            vendedores[4] = new Mostrador("Alejandro perez", 2323, 76000, 1);
        }

        public string VerDatoVendedor(int indice)
        {
            string cadena = string.Format("{0} dni:{1} - ${2}", vendedores[indice].ToString(), vendedores[indice].Dni, vendedores[indice].Sueldo());
            if(vendedores[indice] is Online ons)
            {
                cadena+=string.Format(" Promedio: {0}",ons.Promedio());
            }
            return cadena;
        }

        public string VerNombreVendedor(int indice)
        {
            return vendedores[indice].ToString();
        }

        public void AgregarVenta(int indice, double monto)
        {
            vendedores[indice].AgregarVenta(monto);
        }
    }
}
