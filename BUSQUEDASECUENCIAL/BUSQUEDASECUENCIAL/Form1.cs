using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUSQUEDASECUENCIAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] Vec = new int[10];
        Random rnd = new Random();
        int i,Num;
        string Men,Men2;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            for (i = 0; i < 10; i++)
            {
                Men = Microsoft.VisualBasic.Interaction.InputBox("Numero " + (i+1) + ": ");
                Vec[i] = Convert.ToInt32(Men);
                textBox1.Text = textBox1.Text + Vec[i] + ", ";
            }
            
        }

        private void ALEATORIO_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            for (i = 0; i < 10; i++)
            {
                Vec[i] = rnd.Next(0, 100);
                textBox1.Text = textBox1.Text + Vec[i] + ", ";
            }
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            textBox2.Text = " ";            
            bool Op2=false;
            Men2 = Microsoft.VisualBasic.Interaction.InputBox("Numero a buscar: ");
            Num = Convert.ToInt32(Men2);
            for (i = 0; i < 10; i++)
            {
                if (Vec[i]==Num)                
                    Op2 = true;  
            }
            if (Op2 == true)            
                textBox2.Text = "Numero encontrado!";            
            else
                textBox2.Text = "Numero no encontrado.";
        }
    }
}
