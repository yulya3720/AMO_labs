namespace lab4_AMO
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.a_box = new System.Windows.Forms.TextBox();
            this.b_box = new System.Windows.Forms.TextBox();
            this.e_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calc_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // a_box
            // 
            this.a_box.Location = new System.Drawing.Point(110, 120);
            this.a_box.Name = "a_box";
            this.a_box.Size = new System.Drawing.Size(120, 22);
            this.a_box.TabIndex = 0;
            this.a_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.a_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputField_KeyPressed);
            // 
            // b_box
            // 
            this.b_box.Location = new System.Drawing.Point(110, 180);
            this.b_box.Name = "b_box";
            this.b_box.Size = new System.Drawing.Size(120, 22);
            this.b_box.TabIndex = 1;
            this.b_box.TextChanged += new System.EventHandler(this.b_box_TextChanged);
            this.b_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.b_box_KeyPressed);
            // 
            // e_box
            // 
            this.e_box.Location = new System.Drawing.Point(110, 240);
            this.e_box.Name = "e_box";
            this.e_box.Size = new System.Drawing.Size(120, 22);
            this.e_box.TabIndex = 2;
            this.e_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.e_box_KeyPressed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(50, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "a:=";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(50, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "b:=";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(50, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "e:=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(47, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "lg(x) - 1/x^2 = 0";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // calc_button
            // 
            this.calc_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calc_button.Location = new System.Drawing.Point(55, 321);
            this.calc_button.Name = "calc_button";
            this.calc_button.Size = new System.Drawing.Size(283, 48);
            this.calc_button.TabIndex = 7;
            this.calc_button.Text = "Розрахувати";
            this.calc_button.UseVisualStyleBackColor = true;
            this.calc_button.Click += new System.EventHandler(this.calc_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 477);
            this.Controls.Add(this.calc_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.e_box);
            this.Controls.Add(this.b_box);
            this.Controls.Add(this.a_box);
            this.Name = "Form1";
            this.Text = "Лабораторна 4: метод хорд";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox a_box;
        private System.Windows.Forms.TextBox b_box;
        private System.Windows.Forms.TextBox e_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calc_button;
    }
}

