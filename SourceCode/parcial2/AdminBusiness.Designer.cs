using System.ComponentModel;
using System.Windows.Forms;

namespace parcial2
{
    partial class AdminBusiness
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
            this.label4.Location = new System.Drawing.Point(61, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 60);
            this.label4.TabIndex = 0;
            this.label4.Text = "Business ID";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(61, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 60);
            this.label5.TabIndex = 1;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(61, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 60);
            this.label6.TabIndex = 2;
            this.label6.Text = "Info";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (192)))),
                ((int) (((byte) (255)))));
            this.textBox4.Location = new System.Drawing.Point(153, 80);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(246, 27);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (192)))),
                ((int) (((byte) (255)))));
            this.textBox5.Location = new System.Drawing.Point(153, 200);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(246, 27);
            this.textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (192)))),
                ((int) (((byte) (255)))));
            this.textBox6.Location = new System.Drawing.Point(153, 140);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(246, 27);
            this.textBox6.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (255)))),
                ((int) (((byte) (255)))));
            this.button2.Location = new System.Drawing.Point(153, 266);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 108);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add Business";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // AdminBusiness
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
            this.Name = "AdminBusiness";
            this.Text = "AdminBusiness";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox6;
        private TextBox textBox5;
        private Button button2;
    }
}