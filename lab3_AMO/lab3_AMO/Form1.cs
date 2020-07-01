using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_AMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double a = 0;
            double b = 2;
            double h = (b - a) / 10;
            
            for (int i = 0; i <= n; i++){
                xArray.Add(i * h);
            }

        }

        int n = 50;
        List<double> xArray = new List<double>();
        List<double> yArraySin = new List<double>();
        List<double> yArraySinInterpolated = new List<double>();
        List<double> yArrayFunc = new List<double>();
        List<double> yArrayFuncInterpolated = new List<double>();
        List<double> yArrayMistake = new List<double>();

        private void sin()
        {

                for (int i = 0; i < xArray.Count; i++)
                {
                    yArraySin.Add(Math.Sin(xArray[i]));
                }
            
        }
        private void function()
        {
           
            for(int i = 0; i < xArray.Count; i++)
            {
                yArrayFunc.Add(Math.Pow(Math.E, Math.Cos(xArray[i])) * Math.Cos(xArray[i]*xArray[i]));
            }
            
        }
        List<double> xi = new List<double>();
        private void mistake()
        {
            
            List<double> actual = new List<double>();
            List<double> interpolated = new List<double>();
            for(int i = 0; i < xArray.Count/2; i++)
            {
                xi.Add(xArray[i]);
                xi.Add((xArray[i] + xArray[i + 1]) / 2);
            }
            for(int i = 0; i < xArray.Count/2; i++)
            {
                actual.Add(Math.Pow(Math.E, Math.Cos(xi[i])) * Math.Cos(xi[i] * xi[i]));
                interpolated.Add(yArrayFuncInterpolated[i]);
                interpolated.Add((yArrayFuncInterpolated[i] + yArrayFuncInterpolated[i+1])/2);
            }
            for(int i = 0; i < xArray.Count/2; i++)
            {
                yArrayMistake.Add(Math.Abs((actual[i] - interpolated[i])));
            }
        }
        private List<double> lagrange(List<double> yArray)
        {
            List<double> sum = new List<double>();
            List<double> product = new List<double>();
            for (int k = 0; k <= n; k++)
            {
                sum.Add(0);
                product.Add(1);
            }
            for (int j = 0; j <= n; j++) {
                for (int i = 0; i <=n; i++) {
                    if (i != j) {
                        for (int a = 0; a < product.Count; a++) {
                            product[a] *= (xArray[a] - xArray[i]) / (xArray[j] - xArray[i]);
                        }
                    }
                }
                for (int b = 0; b < sum.Count; b++)
                {
                    sum[b] += product[b] * yArray[b];
                    product[b] = 1;
                }
            }
            return  sum;
        }


        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sin_btn_Click(object sender, EventArgs e)
        {
            sin();
            yArraySinInterpolated  = lagrange(yArraySin);
            Form sinForm = new sinForm(xArray, yArraySin, yArraySinInterpolated) ;
            sinForm.Show();
        }

        private void interpolation_btn_Click(object sender, EventArgs e)
        {
            function();
            yArrayFuncInterpolated =  lagrange(yArrayFunc);
            Form funcForm = new funcForm(xArray, yArrayFunc, yArrayFuncInterpolated);
            funcForm.Show();
        }

        private void error_btn_Click(object sender, EventArgs e)
        {
            if (!yArrayFuncInterpolated.Any())
            {
                function();
                yArrayFuncInterpolated = lagrange(yArrayFunc);
            }
            if (!yArrayMistake.Any())
            {
                mistake();
                
            }
            Form mistakeForm = new mistakeForm(xi, yArrayMistake);
            mistakeForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
