using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Lab2
{
    abstract class Prendas
    {
        public int precio;
        public int cantidad;
        public int calidad;

        protected Prendas(int precio, int cantidad,int calidad)
        {
            this.precio = precio;
            this.cantidad = cantidad;
            this.calidad = calidad;
        }

        public int getPrecio()
        {
            return this.precio;
        }

        public int getCantidad()
        {
            return this.cantidad;
        }

        public int getCalidad()
        {
            return this.calidad;
        }


        public abstract double CalcularPrecio();

    }
}
