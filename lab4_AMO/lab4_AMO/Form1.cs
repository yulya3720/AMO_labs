using System;
using System.Globalization;
using System.Windows.Forms;

namespace lab4_AMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
        private double func(double x)
        {
            return  Math.Log(x, 10) - 1/Math.Pow(x, 2);
        }
        private double func1(double x)
        {
            double f = ((Math.Pow(x, 2) + 2 * Math.Log(10, Math.E)) / (Math.Log(10, Math.E)) / Math.Pow(x, 3));
            return f;
        }
        private double func2(double x)
        {
            double f = (-(Math.Pow(x, 2) + 6 * Math.Log(10, Math.E)) / (Math.Log(10, Math.E)) / Math.Pow(x, 4));
            return f;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void inputField_KeyPressed(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool flag = a_box.Text.Contains(".") || a_box.Text.Contains(",") || a_box.Text == "";
            if (!char.IsControl(e.KeyChar)
             && !char.IsDigit(e.KeyChar)
             && e.KeyChar != '.' 
             && e.KeyChar != ','
            || (flag && (e.KeyChar == '.' || e.KeyChar == ','))
            )
            {
                e.Handled = true;
                return;
            }
            e.Handled = false;
            return;
        }

        private void b_box_TextChanged(object sender, EventArgs e)
        {

        }
        private void b_box_KeyPressed(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool flag = b_box.Text.Contains(".") || b_box.Text.Contains(",") || b_box.Text == "";
            if (!char.IsControl(e.KeyChar)
             && !char.IsDigit(e.KeyChar)
             && e.KeyChar != '.'
             && e.KeyChar != ','
            || (flag && (e.KeyChar == '.' || e.KeyChar == ','))
            )
            {
                e.Handled = true;
                return;
            }
            e.Handled = false;
            return;
        }
        private void e_box_KeyPressed(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            bool flag = e_box.Text.Contains(".") || e_box.Text.Contains(",") || e_box.Text == "";
            if (!char.IsControl(e.KeyChar)
             && !char.IsDigit(e.KeyChar)
             && e.KeyChar != '.'
             && e.KeyChar != ','
            || (flag && (e.KeyChar == '.' || e.KeyChar == ','))
            )
            {
                e.Handled = true;
                return;
            }
            e.Handled = false;
            return;
        }
        private double iteration(double a, double b, ref int k, double E) 
        {
            double x;
            x = a - (func(a)*(b - a)) / (func(b) - func(a));
            k++;
            double temp = Math.Abs(x - a);
            if (temp < E)
            {
                return x;
            }
            else
            {
                return iteration(x, b, ref k, E);
            }
        }
        private void calc_button_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Double.Parse(a_box.Text.Replace(',', '.'), System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture);
                double b = Double.Parse(b_box.Text.Replace(',', '.'), System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture);
                double E = Double.Parse(e_box.Text.Replace(',', '.'), System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture);
                double x;
                if (a > b)
                {
                    double foo = a;
                    a = b;
                    b = foo;
                }
                if (func(a) * func(b) < 0 && E != 0)
                {
                    int k = 0;
                    if (func1(1) * func2(1) <= 0)
                    {
                        double foo = a;
                        a = b;
                        b = foo;
                    }
                    x = iteration(a, b, ref k, E);


                    Form2 form = new Form2("x = " + x.ToString(), "виконано " + k.ToString() + " ітерацій");
                    form.Show();
                }

                else
                {
                    MessageBox.Show("Не вийшло :( \nСпробуйте ввести інші дані.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Не вийшло :( \nСпробуйте ввести інші дані.");
            }

            catch (OverflowException)
            {
                MessageBox.Show("Якесь з чисел занадто велике для опрацювання. \nСпробуйте ввести інші дані.");
            }
        }

    }
}
