using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms.DataVisualiation.Charting;

namespace lab2_AMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private TimeSpan time;
        private List<double> XTheoretical = new List<double>();
        private List<double> YTheoretical = new List<double>();
        private List<int> XPractical = new List<int>();
        private List<double> YPractical = new List<double>();
        private void calcPractical()
        {
            Stopwatch watch = new Stopwatch();
            List<int> temp = new List<int>();

            for (int i = 0; i <= 10; i++)
            {
                XPractical.Add(i*10000 + 1);
                temp = generateNNumbers(XPractical[i]);
                watch.Start();
                quicksort(temp, 0, temp.Count - 1);
                watch.Stop();
                YPractical.Add(watch.ElapsedMilliseconds);

            }
        }
        private void calcTheoretical(int min, int max, int step)
        {
            int n = (max - min) / step;
            for (int i = 0; i <= n; i++)
            {
                XTheoretical.Add(min + i * step);
                YTheoretical.Add(XTheoretical[i] * Math.Log(XTheoretical[i], 2));
            }
        }
        private List<int> generateNNumbers(int n)
        {
            Random random = new Random();
            List<int> generated = new List<int>();
            for (int i = 0; i < n; i++)
            {
                generated.Add(random.Next(-1000, 1000));
            }
            return generated;
        }

        private List<int> InputToNumberList(string input) {
            List<int> intValues = new List<int>();
            List<string> stringValues = input.Split(' ').ToList();
            foreach (string strValue in stringValues)
            {
                if (!(strValue == " ") && !(strValue == ""))
                {
                    try
                    {
                        intValues.Add(Int32.Parse(strValue));
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Невірно задані дані. Спробуйте ще.");
                        intValues.Clear();
                        break;
                    }
                }
            }
            return intValues;
        }
        

        private string NumberListToString(List<int> intValues)
        {
            string output = "";
            foreach (int value in intValues)
            {
                output += value.ToString() + " ";
            }
            return output;
        }

        int partition(List<int> array, int start, int end)
        {
            int temp;//swap helper
            int marker = start;//divides left and right subarrays
            for (int i = start; i <= end; i++)
            {
                if (array[i] < array[end]) //array[end] is pivot
                {
                    temp = array[marker]; // swap
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }
            //put pivot(array[end]) between left and right subarrays
            temp = array[marker];
            array[marker] = array[end];
            array[end] = temp;
            return marker;
        }

        void quicksort(List<int> array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int pivot = partition(array, start, end);
            quicksort(array, start, pivot - 1);
            quicksort(array, pivot + 1, end);
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Stopwatch stopwatch = new Stopwatch();

                List<int> intValues = InputToNumberList(inputField.Text);
                stopwatch.Start();
                quicksort(intValues, 0, intValues.Count - 1);
                stopwatch.Stop();
                time = stopwatch.Elapsed;
                string output = NumberListToString(intValues);
                outputField.Text = output;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Якесь з уведених чисел занадто велике для опрацювання. Числа мають бути у діапазоні [-2 147 483 648; 2 147 483 647].");
            }
        }

        private void readFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    var streamReader = new StreamReader(openFileDialog1.FileName);
                    string content = streamReader.ReadToEnd();

                    while (content[content.Length - 1] == ' ')
                    {
                        content = content.Remove(content.Length - 1);
                    }
                    List<string> stringValues = content.Split(' ').ToList<string>();
                    List<int> intValues = new List<int>();

                    inputField.Text = content;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Помилка доступу до файлу.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Файл має містити тільки числа.");
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Приймаються числа в діапазоні [ -10^8 ; 10^8 ].");

                }
            }
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введіть у поле або файл цілі числа, розділяючи їх пробілами.");
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            List<int> generated = generateNNumbers(100);
            inputField.Text += NumberListToString(generated);
        }

        private void iutputField_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void showTimeBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(time.ToString());
        }

        private void chartBtn_Click(object sender, EventArgs e)
        {
            calcPractical();
            calcTheoretical(1, 100001, 10000);
            Form2 form2 = new Form2(XPractical, YPractical, XTheoretical, YTheoretical);
            Form fc = Application.OpenForms["form2"];
            if (fc==null)
            {
                form2.Show();
            }
            XPractical.Clear();
            YPractical.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void inputField_KeyPressed(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar)
             && !char.IsDigit(e.KeyChar)
             && e.KeyChar != ' ' && e.KeyChar != '-')
            {
                e.Handled = true;
                return;
            }
            e.Handled = false;
            return;
        }

        private void inputField_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputField.Text = "";
            outputField.Text = "";
        }
    }
}
