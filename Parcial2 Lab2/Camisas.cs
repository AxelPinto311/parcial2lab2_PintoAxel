using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Lab2
{
    class Camisas:Prendas
    {

        public int mangascortas;

        //Constructor para creacion de camisa

        public Camisas(int cantidad,int precio,int calidad,int mangascortas)
            :base(precio,cantidad,calidad)
        {
            this.mangascortas=mangascortas;
        }
    


        public int getMangascortas()
        {
            return this.mangascortas;
        }



        //Metodo que calcula el precio total
        public override double CalcularPrecio()
        {
            double total=getPrecio();

         
            //Si la camisa es mangas cortas se rebaja un 10%
            if (getMangascortas() == 1)
            {
                total = total - ((total * 10) / 100);
            }

            // Si la calidad es premium se suma un 30%
            if (getCalidad() == 1)
            {
                total = total + ((total * 30) / 100);
            }

            total = total * getCantidad();
            return total;
        }
    }
}
