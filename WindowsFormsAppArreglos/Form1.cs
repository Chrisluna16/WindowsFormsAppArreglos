using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppArreglos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            int[,] datosLluvia =
            {{0, 7, 3, 28, 5, 6, 3},
            {12, 3, 5, 7, 12, 5, 8},
            { 8, 5, 2, 1, 1, 4, 7}};
        private void button1_Click(object sender, EventArgs e)
        {
            {
                textBox4.Clear();
                for (int ubicación = 0; ubicación <= 2; ubicación++)
                {
                    for (int númeroDía = 0; númeroDía <= 6; númeroDía++)
                    {
                        textBox4.AppendText(Convert.ToString

                        (datosLluvia[ubicación, númeroDía]) + "\t");

                    }
                    textBox4.AppendText("\r\n");
                }
        
            }

           
            {
                int valorDatos;
                int númeroDía;
                int ubicación;
                númeroDía = Convert.ToInt32(díaTextBox.Text);
                ubicación = Convert.ToInt32(ubicaciónTextBox.Text);
                valorDatos = Convert.ToInt32(valorTextBox.Text);
                datosLluvia[ubicación, númeroDía] = valorDatos;
                
            }

            {
                int total = 0;
                for (int ubicación = 0; ubicación <= 2; ubicación++)
                {
                    for (int númeroDía = 0; númeroDía <= 6; númeroDía++)
                    {
                        total = total + datosLluvia[ubicación, númeroDía];
                    }
                }
                label4.Text = "el total de precipitación pluvial es " + Convert.ToString(total);
            }



        }
    }
}
