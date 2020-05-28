using System;
using System.Windows.Forms;

namespace parcial2
{
    public partial class DeleteOrder : Form
    {
        public DeleteOrder()
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
                Conexion.ExecuteNonQuery($"delete from apporder where idproduct = '{textBox1.Text}'");
                MessageBox.Show("Se ha eliminado de la base de datos");
                Close();
            }
        }
    }
    
}