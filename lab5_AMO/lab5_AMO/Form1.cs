using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5_AMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBoxValidation(TextBox textbox, ref KeyPressEventArgs e)
        {
            bool flag = textbox.Text.Contains(".") || textbox.Text.Contains(",") || textbox.Text == "";
            if (!char.IsControl(e.KeyChar)
             && !char.IsDigit(e.KeyChar)
             && e.KeyChar != '.'
             && e.KeyChar != ','
             && e.KeyChar != '-'
            || (textbox.Text != "" && e.KeyChar == '-')
            || (flag && (e.KeyChar == '.' || e.KeyChar == ','))
            )
            {
                e.Handled = true;
                return;
            }
            e.Handled = false;
            return;
        }
        
        private double[,] inpMatrix = new double[3,3];
        private double[] inpVector = new double[3];
        private void refreshInput()
        {
            inpMatrix[0, 0] = Double.Parse(x11.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture);
            inpMatrix[0, 1] = Double.Parse(x21.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture);
            inpMatrix[0, 2] = Double.Parse(x31.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture);
            inpMatrix[1, 0] = Double.Parse(x12.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture); 
            inpMatrix[1, 1] = Double.Parse(x22.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture);
            inpMatrix[1, 2] = Double.Parse(x32.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture);
            inpMatrix[2, 0] = Double.Parse(x13.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture);
            inpMatrix[2, 1] = Double.Parse(x23.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture);
            inpMatrix[2, 2] = Double.Parse(x33.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture);
            inpVector[0] = Double.Parse(y1.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture);
            inpVector[1] = Double.Parse(y2.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture);
            inpVector[2] = Double.Parse(y3.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture);

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void x11_KeyPressed(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            textBoxValidation(x11, ref e);
        }
        private void x12_KeyPressed(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            textBoxValidation(x12, ref e);
        }
        private void x13_KeyPressed(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            textBoxValidation(x13, ref e);
        }
        private void x21_KeyPressed(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            textBoxValidation(x21, ref e);
        }
        private void x22_KeyPressed(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            textBoxValidation(x22, ref e);
        }
        private void x23_KeyPressed(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            textBoxValidation(x23, ref e);
        }
        private void x31_KeyPressed(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            textBoxValidation(x31, ref e);
        }
        private void x32_KeyPressed(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            textBoxValidation(x32, ref e);
        }
        private void x33_KeyPressed(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            textBoxValidation(x33, ref e);
        }
        private void y1_KeyPressed(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            textBoxValidation(y1, ref e);
        }
        private void y2_KeyPressed(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            textBoxValidation(y2, ref e);
        }
        private void y3_KeyPressed(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            textBoxValidation(y3, ref e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Control> c = groupBox1.Controls.OfType<TextBox>().Cast<Control>().ToList();
            foreach(Control cntrl in c)
            {
                cntrl.Text = "";
            }
            x1.Text = "X1 = " ;
            x2.Text = "X2 = " ;
            x3.Text = "X3 = " ;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                refreshInput();
                Matrix matrix = new Matrix(inpMatrix);
                Vector vector = new Vector(inpVector);
                Vector result = Gauss.solve(matrix, vector, 3);
                if (!double.IsNaN(result.getElement(0)))
                {
                    x1.Text = "X1 = " + result.getElement(0).ToString();
                    x2.Text = "X2 = " + result.getElement(1).ToString();
                    x3.Text = "X3 = " + result.getElement(2).ToString();
                }
                else
                {
                    MessageBox.Show("Не вийшло :( \nСпробуйте ввести інші дані.");
                    x1.Text = "";
                    x2.Text = "";
                    x3.Text = "";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Не вийшло :( \nСпробуйте ввести інші дані.");
                x1.Text = "";
                x2.Text = "";
                x3.Text = "";

            }
            catch (OverflowException)
            {
                MessageBox.Show("Якесь з чисел занадто велике для опрацювання. \nСпробуйте ввести інші дані.");
                x1.Text = "";
                x2.Text = "";
                x3.Text = "";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
