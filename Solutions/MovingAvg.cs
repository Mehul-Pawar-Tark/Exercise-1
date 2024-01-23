using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class MovingAvg
    {
        public double difference(int k, double[] data)
        {
            int Length=data.Length;
            double sum = 0;
          
            for(int index=0; index<k; index++)
            {
                sum += data[index];
            }

            double Minimum = sum / k;
            double Maximum = sum / k;

            for(int index=k; index<Length; index++)
            {
                sum += data[index] - data[index - k];

                //Update Minimum and Maximum average values

                if ( (sum/k) < Minimum)
                    Minimum = sum / k;
            
                if ( (sum/k) > Maximum)
                    Maximum = sum / k;
            }

            return Maximum-Minimum;
        }
    }
}
