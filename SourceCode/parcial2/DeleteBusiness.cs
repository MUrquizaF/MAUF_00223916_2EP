using System;
using System.Windows.Forms;

namespace parcial2
{
    public partial class DeleteBusiness : Form
    {
        public DeleteBusiness()
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
                Conexion.ExecuteNonQuery($"delete from business where name = '{textBox1.Text}'");
                MessageBox.Show("Se elimino registro");
                Close();
            }
        }
    }
}