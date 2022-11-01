using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace galina_lab2
{
    public partial class Square : Form
    {
        public Square()
        {
            InitializeComponent();
        }

        public void Square_Load(object sender, EventArgs e)
        {

        }

        public void label6_Click(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        public void textBox6_TextChanged(object sender, EventArgs e)
        {
       
        }

        public void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void textBox8_TextChanged(object sender, EventArgs e)
        {
          
        }
        

        public void label5_Click(object sender, EventArgs e)
        {

        }

        public void label7_Click(object sender, EventArgs e)
        {

        }

        public void label8_Click(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox2.Text);
            double y = Convert.ToDouble(textBox6.Text);
            double x1 = Convert.ToDouble(textBox7.Text);
            double y1 = Convert.ToDouble(textBox8.Text);
            double dx = x - y;
            double dy = x1 - y1;
            double result = Math.Sqrt(dx * dx + dy * dy);
            double perimetr = result * 10;
            Form2 frm = new Form2();
            frm.perimetr = perimetr;
            frm.Show();
        }
    }
}
