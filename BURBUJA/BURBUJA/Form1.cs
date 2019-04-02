using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BURBUJA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] Vec = new int[10];
        int i;
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
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

        private void ordenar_Click(object sender, EventArgs e)
        {
            textBox2.Text = " ";
            int aux,j;
            for (i = 0; i < 10; i++)
            {
                for (j =0;j<9;j++)
                {
                    if (Vec[j] > Vec[j + 1])
                    {
                        aux = Vec[j];
                        Vec[j] = Vec[j + 1];
                        Vec[j+1]=aux;
                    }

                    
                }
            }
            for (i = 0; i < 10; i++)
            {
                
                textBox2.Text = textBox2.Text + Vec[i] + ", ";
            }
        }
    }}
