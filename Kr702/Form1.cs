namespace Kr702
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ïàíåëü²íñòğóìåíò³âToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true) panel1.Visible = false;
            else panel1.Visible = true;
        }

        private void ïğîÏğîãğàìóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show();
        }
    }
}
