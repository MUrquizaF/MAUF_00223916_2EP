using System;
using System.Windows.Forms;

namespace parcial2
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" ||
                textBox2.Text == "" ||
                textBox3.Text == "" ||
                textBox4.Text == "" ||
                textBox5.Text == "" ||
                textBox6.Text == "")
            {
                MessageBox.Show("No dejar espacios vacios");
            }
            else
            {
                
                Conexion.ExecuteNonQuery("insert into appuser values(" +
                                         $"'{textBox1.Text}'," +
                                         $"'{textBox2.Text}'," +
                                         $"'{textBox6.Text}'," +
                                         $"'{textBox3.Text}'," +
                                         $"'{textBox4.Text}'," +
                                         $"{textBox5.Text})");
                MessageBox.Show("Se ha almacenado en la base de datos");
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}