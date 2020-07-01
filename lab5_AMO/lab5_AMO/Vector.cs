using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_AMO
{
    public class Vector
    {
        private double[] vector;
        private int length;
        public Vector(double[] vector)
        {
            this.vector = vector;
            length = vector.Length;
        }
        public double getElement(int index)
        {
            return vector[index];
        }
        public void setElement(int index, double val)
        {
            vector[index] = val;
        }
        public Vector setAll(Double val)
        {
            for(int i = 0; i < this.length; i++)
            {
                vector[i] = val;
            }
            return this;
        }
        public int getLength()
        {
            return length;
        }
        public void swap(int v1, int v2)
        {
            double c = vector[v1];
            vector[v1] = vector[v2];
            vector[v2] = c;
        }
        public void add(int v1, int v2, double k)
        {
            vector[v1] += vector[v2] * k;
        }
        public void multiply(int v, double m)
        {
            vector[v] *= m;
        }
 
        public String toString()
        {
            string str = String.Join(",", vector.Select(p => p.ToString()).ToArray());
            return str;
        }
        public Vector copyOf()
        {
            return new Vector((double[])vector.Clone());
        }
    }
}
