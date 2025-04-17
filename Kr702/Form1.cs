namespace Kr702
   
{
    using Google.Protobuf.WellKnownTypes;
    using MySql.Data.MySqlClient;
    using System.Data;
    using System.IO.Pipelines;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection coon = new MySqlConnection("Server=localhost;Database=bd702;port=3306;User Id=root;passvord=");
        int currId = 0, k = 0, i, j;
        string currPip = "";
        int currGroup = 0;
        double currSb = 0;
        Image imag;
        private void панельІнструментівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true) panel1.Visible = false;
            else panel1.Visible = true;
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show();
        }
        public void FiilDGV()
        {
            string fillstr = "SELECT * FROM `student`";
            MySqlCommand cmd = new MySqlCommand(fillstr, coon);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            coon.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FiilDGV();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ZapId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            MessageBox.Show("Виділено запис-" + ZapId);
        }

        public void DeleteRecord(int id)
        {
            try
            {
                coon.Open();
                string query = "DELETE FROM student WHERE id = @id;";
                MySqlCommand cmd = new MySqlCommand(query, coon);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Виникла помилка" + ex.Message);
                coon.Close();
            }
            MessageBox.Show("Pапис-" + id + " було видалено");
            FiilDGV();
            coon.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Видалення запису
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DeleteRecord(id);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
        public void AddRecord(string pip, int gr, float sb)
        {
            try
            {
                coon.Open();
                string query = "INSERT INTO student (id, pip, gr, sb, photo, harakter) VALUES (NULL, @pip, @gr, @sb, NULL, NULL);";

                MySqlCommand cmd = new MySqlCommand(query, coon);
                cmd.Parameters.AddWithValue("@pip", pip);
                cmd.Parameters.AddWithValue("@gr", gr);
                cmd.Parameters.AddWithValue("@sb", sb);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Виникла помилка" + ex.Message);

            }
            MessageBox.Show("Запис додано");
            FiilDGV();
            coon.Close();
            tabControl1.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string pip = textBox1.Text;
            int group = Convert.ToInt32(textBox2.Text);
            float sb = Convert.ToSingle(textBox3.Text);
            AddRecord(pip, group, sb);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            currId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            currPip = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            currGroup = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
            currSb = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
            tabControl1.SelectedIndex = 2;
            textBox8.Text = currPip;
            textBox7.Text = currGroup.ToString();
            textBox6.Text = currSb.ToString();

        }
        public void EditRecord(int id, string pip, int gr, double sb)
        {
            try
            {
                coon.Open();
                string query = "UPDATE student SET pip = @pip, gr = @gr, sb = @sb WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(query, coon);
                cmd.Parameters.AddWithValue("@pip", pip);
                cmd.Parameters.AddWithValue("@gr", gr);
                cmd.Parameters.AddWithValue("@sb", sb);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Виникла помилка" + ex.Message);

            }
            MessageBox.Show("Запис відредаговано");
            FiilDGV();
            coon.Close();
            tabControl1.SelectedIndex = 0;
        }
        private void button5_Click(object sender, EventArgs e)
        {
           
            currPip = textBox8.Text;
            currGroup = Convert.ToInt32(textBox7.Text);
            currSb = Convert.ToSingle(textBox6.Text);
            EditRecord(currId, currPip, currGroup, currSb);
        }
    }
}
