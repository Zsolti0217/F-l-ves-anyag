using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace korbekorbe
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

        private void button2_Click(object sender, EventArgs e)
        {
            //balra
            Image a = label1.Image;

            label1.Image = label2.Image;
            label2.Image = label3.Image;
            label3.Image = label4.Image;
            label4.Image = label5.Image;
            label5.Image = label6.Image;
            label6.Image = label7.Image;
            label7.Image = label8.Image;
            label8.Image = a;


        }

        private void button1_Click(object sender, EventArgs e)
        {   //jobbra
            Image a = label1.Image;

            label8.Image = label7.Image;
            label7.Image = label6.Image;
            label6.Image = label5.Image;
            label5.Image = label5.Image;
            label5.Image = label4.Image;
            label4.Image = label3.Image;
            label3.Image = label2.Image;
            label2.Image = label1.Image;
            label1.Image = a;
        }
    }
}
