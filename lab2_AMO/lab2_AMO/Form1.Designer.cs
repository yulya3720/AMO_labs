namespace lab2_AMO
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputField = new System.Windows.Forms.TextBox();
            this.helpBtn = new System.Windows.Forms.Button();
            this.readFileBtn = new System.Windows.Forms.Button();
            this.generateBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chartBtn = new System.Windows.Forms.Button();
            this.showTimeBtn = new System.Windows.Forms.Button();
            this.outputField = new System.Windows.Forms.MaskedTextBox();
            this.sortBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.inputField);
            this.groupBox1.Controls.Add(this.helpBtn);
            this.groupBox1.Controls.Add(this.readFileBtn);
            this.groupBox1.Controls.Add(this.generateBtn);
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введіть дані";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // inputField
            // 
            this.inputField.Location = new System.Drawing.Point(40, 50);
            this.inputField.Name = "inputField";
            this.inputField.Size = new System.Drawing.Size(570, 22);
            this.inputField.TabIndex = 4;
            this.inputField.TextChanged += new System.EventHandler(this.inputField_TextChanged);
            this.inputField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputField_KeyPressed);
            // 
            // helpBtn
            // 
            this.helpBtn.Location = new System.Drawing.Point(460, 120);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(120, 45);
            this.helpBtn.TabIndex = 3;
            this.helpBtn.Text = "Підказка";
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // readFileBtn
            // 
            this.readFileBtn.Location = new System.Drawing.Point(310, 120);
            this.readFileBtn.Name = "readFileBtn";
            this.readFileBtn.Size = new System.Drawing.Size(120, 45);
            this.readFileBtn.TabIndex = 2;
            this.readFileBtn.Text = "Ввести з файлу";
            this.readFileBtn.UseVisualStyleBackColor = true;
            this.readFileBtn.Click += new System.EventHandler(this.readFileBtn_Click);
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(160, 120);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(120, 45);
            this.generateBtn.TabIndex = 1;
            this.generateBtn.Text = "Згенерувати";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chartBtn);
            this.groupBox2.Controls.Add(this.showTimeBtn);
            this.groupBox2.Controls.Add(this.outputField);
            this.groupBox2.Location = new System.Drawing.Point(20, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(740, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат";
            // 
            // chartBtn
            // 
            this.chartBtn.Location = new System.Drawing.Point(385, 120);
            this.chartBtn.Name = "chartBtn";
            this.chartBtn.Size = new System.Drawing.Size(120, 45);
            this.chartBtn.TabIndex = 5;
            this.chartBtn.Text = "Побудувати графік";
            this.chartBtn.UseVisualStyleBackColor = true;
            this.chartBtn.Click += new System.EventHandler(this.chartBtn_Click);
            // 
            // showTimeBtn
            // 
            this.showTimeBtn.Location = new System.Drawing.Point(235, 120);
            this.showTimeBtn.Name = "showTimeBtn";
            this.showTimeBtn.Size = new System.Drawing.Size(120, 45);
            this.showTimeBtn.TabIndex = 4;
            this.showTimeBtn.Text = "Витрачено часу";
            this.showTimeBtn.UseVisualStyleBackColor = true;
            this.showTimeBtn.Click += new System.EventHandler(this.showTimeBtn_Click);
            // 
            // outputField
            // 
            this.outputField.Location = new System.Drawing.Point(40, 50);
            this.outputField.Name = "outputField";
            this.outputField.ReadOnly = true;
            this.outputField.Size = new System.Drawing.Size(660, 22);
            this.outputField.TabIndex = 4;
            this.outputField.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.iutputField_MaskInputRejected);
            // 
            // sortBtn
            // 
            this.sortBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sortBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortBtn.Location = new System.Drawing.Point(317, 236);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(150, 80);
            this.sortBtn.TabIndex = 2;
            this.sortBtn.Text = "Сортувати";
            this.sortBtn.UseVisualStyleBackColor = false;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(616, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Очистити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Lab 2: quick sort";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Button readFileBtn;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Button chartBtn;
        private System.Windows.Forms.Button showTimeBtn;
        private System.Windows.Forms.MaskedTextBox outputField;
        private System.Windows.Forms.TextBox inputField;
        private System.Windows.Forms.Button button1;
    }
}

