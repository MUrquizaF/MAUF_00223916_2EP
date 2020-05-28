using System.ComponentModel;
using System.Windows.Forms;

namespace parcial2
{
    partial class DeleteProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(63, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ingrese el ID del producto a eliminar";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (255)))),
                ((int) (((byte) (255)))));
            this.button2.Location = new System.Drawing.Point(327, 92);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Delete Product";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (192)))),
                ((int) (((byte) (255)))));
            this.textBox2.Location = new System.Drawing.Point(327, 60);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(349, 27);
            this.textBox2.TabIndex = 2;
            // 
            // DeleteProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DeleteProduct";
            this.Text = "DeleteProduct";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Button button2;
        private Label label2;
    }
}