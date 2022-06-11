using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contact_tracing_1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();    
            Form2 f2 = new();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter A = new(Application.StartupPath + "\\form\\" + "custdetails2.txt");

            A.WriteLine(label1.Text + " " + richTextBox1.Text);
            A.WriteLine(label2.Text + label4.Text + " " + richTextBox2.Text);
            A.WriteLine(label3.Text + label5.Text + " " + richTextBox3.Text);
            A.WriteLine(label6.Text + label7.Text + " " + richTextBox4.Text);

            A.Close();

            MessageBox.Show("Thank you for participating in our tracing program!");

            Application.Exit();
        }
    }
}
