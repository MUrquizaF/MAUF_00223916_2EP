using System;
using System.Windows.Forms;

namespace parcial2
{
    public partial class AdminOption : Form
    {
        private Admin a = new Admin();
        private AdminEliminarUser aa = new AdminEliminarUser();
        public AdminOption()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aa.Show();
        }

        private void AdminOption_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}