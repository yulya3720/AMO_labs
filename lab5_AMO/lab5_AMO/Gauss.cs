using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_AMO
{
    public class Gauss
    {
        public static Vector solve(Matrix matrix, Vector free, int dac)
        {
            int n = free.getLength();
            Vector result = free.copyOf();
            bool hasResult = false;
            double koef = 1.0;
            for (int i = 0; i < n - 1; i++)
            {
                if (matrix.getElement(i, i) == 0)
                {
                    for (int j = i + 1; j < n; j++)
                        if (matrix.getElement(i, j) != 0)
                        {
                            matrix.swapRows(i, j);
                            result.swap(i, j);
                            hasResult = true;
                        }
                    if (!hasResult)
                        return result.setAll(Double.NaN);

                }

                koef = 1.0 / matrix.getElement(i, i);
                matrix.mulRow(i, koef);
                result.multiply(i, koef);
                for (int j = i + 1; j < n; j++)
                {
                    koef = -1.0 * matrix.getElement(j, i);
                    matrix.addRows(j, i, koef);
                    result.add(j, i, koef);
                }
            }
            koef = 1.0 / matrix.getElement(n - 1, n - 1);
            matrix.mulRow(n - 1, koef);
            result.multiply(n - 1, koef);
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    koef = -1.0 * matrix.getElement(j, i);
                    matrix.addRows(j, i, koef);
                    result.add(j, i, koef);
                }
            }
            double pow = Math.Pow(10, dac);
            for (int i = 0; i < n; i++)
            {
                result.setElement(i, Math.Round(result.getElement(i) * pow) / pow);
            }
            return result;
        }
    }
}
