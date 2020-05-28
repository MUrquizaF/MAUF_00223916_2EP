using System;
using System.Windows.Forms;

namespace parcial2
{
    public partial class AdminBusiness : Form
    {
        public AdminBusiness()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" ||
                textBox2.Text == "" ||
                textBox3.Text == "")
            {
                MessageBox.Show("No dejar campos vacios");
            }

            else
            {
                Conexion.ExecuteNonQuery("insert into business values(" +
                                         $"'{textBox1.Text}'," +
                                         $"'{textBox2.Text}'," +
                                         $"'{textBox3.Text}')");
                MessageBox.Show("Se almaceno a la base de datos");
            }
        }
    }
}