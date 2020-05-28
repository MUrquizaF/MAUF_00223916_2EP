using System;
using System.Windows.Forms;

namespace parcial2
{
    public partial class addressuserid : Form
    {
        public addressuserid()
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

                Conexion.ExecuteNonQuery("insert into address values(" +
                                         $"'{textBox1.Text}'," +
                                         $"'{textBox2.Text}'," +
                                         $"'{textBox3.Text}')");
                MessageBox.Show("Se ha guardado direccion");
                Close();
            }
        }

        private void addressuserid_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}