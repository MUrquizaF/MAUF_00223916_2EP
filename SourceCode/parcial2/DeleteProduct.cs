using System;
using System.Windows.Forms;

namespace parcial2
{
    public partial class DeleteProduct : Form
    {
        public DeleteProduct()
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
                Conexion.ExecuteNonQuery($"delete from product where idproduct = '{textBox1.Text}'");
                MessageBox.Show("Se ha eliminado de la base de datos");
                Close();
            }
        }
    }
}