﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_AMO
{
    public partial class Form2 : Form
    {
        public Form2(string label1, string label2)
        {
            InitializeComponent();
            this.label1.Text = label1;
            this.label2.Text = label2;
        }
        private string label1_text;
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
