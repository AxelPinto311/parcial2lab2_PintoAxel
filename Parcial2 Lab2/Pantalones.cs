using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Lab2
{
    class Pantalones:Prendas
    {
        public int bermuda;

        //Constructor para creacion de pantalon
        public Pantalones(int cantidad,int precio,int calidad,int bermuda)
            :base(precio,cantidad,calidad)
        {
            this.bermuda = bermuda;
        }

        public int getBermuda()
        {
            return this.bermuda;
        }


        //Metodo que calcula el precio total
        public override double CalcularPrecio()
        {
            double total = getPrecio();
            //Si el pantalon es bermuda se rebaja un 20%
            if (getBermuda() == 1)
            {
                total = total - ((total * 20) / 100);
            }
            // Si la calidad es premium se suma un 30%
            if (getCalidad() == 1)
            {
                total = total - ((total * 30) / 100);
            }
            total = total * getCantidad();
            return total;
        }
    }
}
