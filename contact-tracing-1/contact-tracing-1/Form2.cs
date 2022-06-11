using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace contact_tracing_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter A = new(Application.StartupPath + "\\form\\" + "custdetails.txt");

            A.WriteLine(label1.Text + " " + textBox1.Text);
            A.WriteLine(label2.Text + " " + textBox2.Text);
            A.WriteLine(label3.Text + " " + textBox3.Text);
            A.WriteLine(label4.Text + " " + textBox4.Text);
            A.WriteLine(label5.Text + " " + textBox5.Text);
            A.WriteLine(label6.Text + " " + textBox6.Text);
            A.WriteLine(label7.Text + " " + richTextBox1.Text);

            A.Close();

            this.Hide();
            Form3 f3 = new();
            f3.Show();
        }
    }
}
