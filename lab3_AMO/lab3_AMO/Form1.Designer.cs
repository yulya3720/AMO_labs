namespace lab3_AMO
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
            this.interpolation_btn = new System.Windows.Forms.Button();
            this.error_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sin_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // interpolation_btn
            // 
            this.interpolation_btn.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.interpolation_btn.Location = new System.Drawing.Point(292, 187);
            this.interpolation_btn.Name = "interpolation_btn";
            this.interpolation_btn.Size = new System.Drawing.Size(233, 60);
            this.interpolation_btn.TabIndex = 0;
            this.interpolation_btn.Text = "Інтерполяція функції";
            this.interpolation_btn.UseVisualStyleBackColor = true;
            this.interpolation_btn.Click += new System.EventHandler(this.interpolation_btn_Click);
            // 
            // error_btn
            // 
            this.error_btn.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error_btn.Location = new System.Drawing.Point(34, 267);
            this.error_btn.Name = "error_btn";
            this.error_btn.Size = new System.Drawing.Size(491, 51);
            this.error_btn.TabIndex = 1;
            this.error_btn.Text = "Похибка ІнтерполяціЇ";
            this.error_btn.UseVisualStyleBackColor = true;
            this.error_btn.Click += new System.EventHandler(this.error_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(139, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Поліном Лагранжа";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // sin_btn
            // 
            this.sin_btn.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sin_btn.Location = new System.Drawing.Point(34, 187);
            this.sin_btn.Name = "sin_btn";
            this.sin_btn.Size = new System.Drawing.Size(233, 60);
            this.sin_btn.TabIndex = 5;
            this.sin_btn.Text = "Інтерполяція sin(x)";
            this.sin_btn.UseVisualStyleBackColor = true;
            this.sin_btn.Click += new System.EventHandler(this.sin_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::lab3_AMO.Properties.Resources.Снимок;
            this.pictureBox1.Location = new System.Drawing.Point(163, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(34, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 140);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Варіант";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 351);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sin_btn);
            this.Controls.Add(this.error_btn);
            this.Controls.Add(this.interpolation_btn);
            this.Name = "Form1";
            this.Text = "lab3_AMO";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button interpolation_btn;
        private System.Windows.Forms.Button error_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sin_btn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

