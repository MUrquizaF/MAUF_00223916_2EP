using System;
using System.Windows.Forms;

namespace parcial2
{
    public partial class AdminEliminarUser : Form
    {
        public AdminEliminarUser()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("No dejar campos vacios");
            }
            else
            {
                try
                {
                    Conexion.ExecuteNonQuery($"delete from appuser where username = '{textBox1.Text}'");
                    MessageBox.Show("Se ha eliminado el usuario");
                    Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }
    }
}