using System;
using System.Windows.Forms;

namespace parcial2
{
    public partial class AdminOp : Form
    {
        private AdminOption o = new AdminOption();
        private OpInventory oo = new OpInventory();
        private ProductInventory inv = new ProductInventory();
        public AdminOp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            o.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inv.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}