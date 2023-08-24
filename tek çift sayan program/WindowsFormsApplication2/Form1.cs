using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int çift=0, tek=0, girilensayı,a;
            for (a = 1; a <= 10; a++) 
            {
                girilensayı = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("sayı giriniz", ""));
                if (girilensayı % 2 == 0) çift++;
                else tek++;

            }
            label3.Text = çift.ToString();
            label4.Text = tek.ToString();
        }
    }
}
