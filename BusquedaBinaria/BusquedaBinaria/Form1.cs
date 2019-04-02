using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusquedaBinaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i;
        int[] Vec = new int[10];
        string t,d;
        public void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = " ";
            for (i = 0; i < Vec.Length; i++)
            {
                
                t = Microsoft.VisualBasic.Interaction.InputBox("Numero: ");
                Vec[i] = Convert.ToInt32(t);
            }
            textBox1.Text = textBox1.Text + "Tu vector: " + Environment.NewLine;
            for (i = 0; i < Vec.Length; i++)
            {
                textBox1.Text = textBox1.Text + Vec[i] + ", ";
            }
        }

        public void buscar_Click(object sender, EventArgs e)
        {
           
            int aux, j;
            for (i = 0; i <Vec.Length; i++)
            {
                for (j = 0; j < Vec.Length-1; j++)
                {
                    if (Vec[j] > Vec[j + 1])
                    {
                        aux = Vec[j];
                        Vec[j] = Vec[j + 1];
                        Vec[j + 1] = aux;
                    }


                }
            }
            /*for (i = 0; i < Vec.Length; i++)
            {
                textBox2.Text = textBox2.Text + Vec[i] + ", ";
            }*/

            int Pri, Ult, Buscador, Centro;
            string Bus;
            bool Ban = false;
            Pri = Vec[0];
            Ult = Vec[Vec.Length - 1];
            Bus = Microsoft.VisualBasic.Interaction.InputBox("Numero a Buscar: ");
            Buscador = Convert.ToInt32(Bus);
            textBox2.Text = textBox2.Text + Environment.NewLine;
            while (Pri <= Ult && Ban==false)
            {
                Centro = (Pri + Ult) / 2;

                if (Buscador == Vec[Centro])
                {
                    Ban = true;
                }
                if (Buscador < Vec[Centro])
                {
                    Ult = Centro - 1;
                }
                else
                {
                    Pri = Centro + 1;
                }
                if (Ban == false)
                {
                    textBox2.Text ="Elemento no encontrado.";
                }
                else
                    textBox2.Text = "El elemento " + Buscador + " esta en la posicion " + (Centro + 1);
            }
        }
    }
}
