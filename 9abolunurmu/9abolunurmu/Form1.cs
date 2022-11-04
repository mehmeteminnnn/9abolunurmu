using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9abolunurmu

{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int toplam, bolunen, x,i;
        private void button1_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);

            toplam = 0;
            bolunen = 0;
            for ( i = 1; i< x+1; i++)
            {
                if (i % 9 == 0)
                {
                    bolunen++;
                    
                    toplam = toplam + i;
                    label4.Text=bolunen.ToString();
                    label2.Text=toplam.ToString();
                }
             
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
