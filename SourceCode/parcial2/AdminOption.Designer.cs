using System.ComponentModel;
using System.Windows.Forms;

namespace parcial2
{
    partial class AdminOption
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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(273, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 68);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select an Option";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (255)))),
                ((int) (((byte) (255)))));
            this.button3.Location = new System.Drawing.Point(273, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 70);
            this.button3.TabIndex = 1;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (255)))),
                ((int) (((byte) (255)))));
            this.button4.Location = new System.Drawing.Point(273, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(240, 70);
            this.button4.TabIndex = 2;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // AdminOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminOption";
            this.Text = "AdminOption";
            this.Load += new System.EventHandler(this.AdminOption_Load);
            this.ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button button2;
        private Button button1;
        private Label label2;
        private Button button3;
        private Button button4;
    }
}