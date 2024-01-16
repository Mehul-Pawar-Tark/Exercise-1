using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class MovingAvg
    {
        public int n;
        public double[]numbers=new double[3];

        public void setInput()
        {
            n= 3;
            numbers = [ 6, 2.5, 3.5] ;
        }
        public double difference(int n, double[] numbers)
        {
            int len=numbers.Length;
            double sum = 0;
          
            for(int i=0; i<n; i++)
            {
                sum += numbers[i];
            }

            double min = sum / n;
            double max = sum / n;

            for(int i=n; i<len; i++)
            {
                sum += numbers[i] - numbers[i - n];

                if((sum/n)<min)
                    min = sum / n;
            
                if ((sum / n) >max)
                    max = sum / n;
            }
            


            return max-min;
        }
    }
}
