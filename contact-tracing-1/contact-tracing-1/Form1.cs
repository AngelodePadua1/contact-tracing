namespace contact_tracing_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new();
            f2.Show();
            Visible = false;
        }
    }
}