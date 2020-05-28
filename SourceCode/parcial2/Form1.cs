using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace parcial2
{
    public partial class Form1 : Form
    {
        private AdminOp op1 = new AdminOp();
        private UserOp op2 = new UserOp();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            var variable = Conexion.ExecuteQuery("select username from appuser");
            var lista = new List<string>();

            foreach (DataRow dr in variable.Rows)
            {
                lista.Add(dr[0].ToString());
            }

            comboBox1.DataSource = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("No dejar campos vacios");
            }

            else
            {
                op1.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("No dejar campos vacios");
            }
            else

                op2.Show();
        }
    }
}