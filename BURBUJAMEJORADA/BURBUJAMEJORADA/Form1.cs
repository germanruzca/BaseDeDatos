using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BURBUJAMEJORADA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] Vec = new int[10];
        Random rnd = new Random();
        int j, i, aux;
        bool Op = true;
        private void ordenar_Click(object sender, EventArgs e)
        {
            for (i = 0; i < 10; i++)
            {
                Op = false;
                for (j = 0; j < 9; j++)
                {
                    if (Vec[j] > Vec[j + 1])
                    {
                        aux = Vec[j];
                        Vec[j] = Vec[j + 1];
                        Vec[j + 1] = aux;
                        Op = true;
                    }                                      
                }
                if (Op == false)
                    break;
            }
            textBox2.Text = " ";
            for (i = 0; i < 10; i++)
            {
                textBox2.Text = textBox2.Text + Vec[i] + ", ";
            }
        }    
        private void llenar_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            for (i = 0; i < 10; i++)
            {
                Vec[i] = rnd.Next(1, 100);
            }
            for (i = 0; i < 10; i++)
            {
                textBox1.Text = textBox1.Text + Vec[i] + ", ";
            }
        }
    }
}