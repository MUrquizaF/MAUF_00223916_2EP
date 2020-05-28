using System;
using System.Windows.Forms;

namespace parcial2
{
    public partial class AddProduct : Form
    {
        public AddProduct()
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
                Conexion.ExecuteNonQuery("insert into product values(" +
                                         $"'{textBox1.Text}'," +
                                         $"'{textBox2.Text}'," +
                                         $"'{textBox3.Text}')");
                MessageBox.Show("Se ha agregador a base de datos");
                Close();
            }
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}