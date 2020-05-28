using System.ComponentModel;
using System.Windows.Forms;

namespace parcial2
{
    partial class addressuserid
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(23, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 74);
            this.label4.TabIndex = 0;
            this.label4.Text = "Address ID";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(23, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 74);
            this.label5.TabIndex = 1;
            this.label5.Text = "User ID";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(23, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 74);
            this.label6.TabIndex = 2;
            this.label6.Text = "Address";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (192)))),
                ((int) (((byte) (255)))));
            this.textBox4.Location = new System.Drawing.Point(182, 82);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(274, 27);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (192)))),
                ((int) (((byte) (255)))));
            this.textBox5.Location = new System.Drawing.Point(182, 222);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(274, 27);
            this.textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (192)))),
                ((int) (((byte) (255)))));
            this.textBox6.Location = new System.Drawing.Point(182, 148);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(274, 27);
            this.textBox6.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (255)))),
                ((int) (((byte) (255)))));
            this.button2.Location = new System.Drawing.Point(182, 310);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 91);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add Address";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // addressuserid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "addressuserid";
            this.Text = "addressuserid";
            this.Load += new System.EventHandler(this.addressuserid_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label6;
        private Label label5;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Button button2;
    }
}