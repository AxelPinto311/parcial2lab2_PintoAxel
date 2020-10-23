using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcularPrecioFinal_Click(object sender, EventArgs e)
        {
            int precio = Convert.ToInt32(txtPrecio.Text);
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            int calidad;
            int mangascortas;
            int bermuda;
            double total=0;

            //Condicion para saber la calidad de la prenda, 0 Standar o 1 premium;
            if (rbtnStandard.Checked == true)
            {
                calidad = 0;
            }
            else
            {
                calidad = 1;
            }



            //Condicion para evaluar si Camisa está seleccionada y Manga corta no.
            if (rbtnCamisa.Checked == true && checkMangacorta.Checked == false)
            {
                mangascortas = 0; //Mangas cortas =1 entonces NO selecciono manga cortas
                Camisas c1 = new Camisas(precio, cantidad, calidad, mangascortas);
                total = c1.CalcularPrecio();
            }
            else

            { //Condicion para evaluar si camisa esta seleccionada y manga corta si.
                if (rbtnCamisa.Checked == true && checkMangacorta.Checked == true)
                {
                    mangascortas = 1;  //Mangas cortas =1 entonces selecciono manga cortas
                    Camisas c1 = new Camisas(precio, cantidad, calidad, mangascortas);
                    total = c1.CalcularPrecio();

                }
                else
                {
                    //Condicion para evaluar si pantalon esta seleccionado y bermuda si.
                    if (rbtnPantalon.Checked == true && checkBermuda.Checked == true)
                    {
                        bermuda = 1; //bermuda =1 entonces selecciono bermuda

                        Pantalones p1 = new Pantalones(precio, cantidad, calidad, bermuda);
                       total= p1.CalcularPrecio();
                    }
                    else
                    {
                        //Condicion para evaluar si pantalon esta seleccionado y bermuda no.
                        if (rbtnPantalon.Checked == true && checkBermuda.Checked == false)
                        {
                            bermuda = 0;//bermuda =1 entonces NO selecciono bermuda
                            Pantalones p1 = new Pantalones(precio, cantidad, calidad, bermuda);
                           total= p1.CalcularPrecio();
                        }
                    }
                }

                 
               
            }
            MessageBox.Show("El precio total es: "+total);
        }

        private void checkMangacorta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnCamisa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCamisa.Checked == true)
            {
                checkMangacorta.Enabled = true;
                checkBermuda.Enabled = false;
            }
        }

        private void rbtnPantalon_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPantalon.Enabled == true)
            {
                
                checkMangacorta.Enabled = false;
                checkBermuda.Enabled = true;
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if(txtCantidad.Text != null && txtPrecio.Text!=null)
            {
                btnCalcularPrecioFinal.Enabled = true;
            }
            else
            {
                btnCalcularPrecioFinal.Enabled = false;
            }
        }
    }
}
