using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class PrintScheduler
    {
        public String getOutput(String[] threads, String[] slices)
        {
            String ThreadsAccurence = "";

            //indexes[] for representing each threads index
            int[] indexes = new int[threads.Length];


            //initialy allthreads are start running form 0 index
            for (int i = 0; i < indexes.Length; i++)
                indexes[i] = 0;


            foreach (String slice in slices)
            {
                int slice_index = 0;

                #region find Thread_no from time_slice

                String Thread_Index_string = "";
                while (slice_index < slice.Length && slice[slice_index] != ' ')
                {
                    Thread_Index_string += slice[slice_index++];
                }

                #endregion
                int Thread_Index = int.Parse(Thread_Index_string);
      

                #region Find Duration from time_slice

                String Duration_String = "";
                while (slice_index < slice.Length)
                {
                    Duration_String += slice[slice_index++];
                }

                #endregion
                int Duration = int.Parse(Duration_String);

                for (int time = 0; time < Duration; time++)
                {
                    String Running_Thread = threads[Thread_Index];
                    ThreadsAccurence += Running_Thread[indexes[Thread_Index]];

                    indexes[Thread_Index]++;
                    indexes[Thread_Index] %= Running_Thread.Length;
                }
            }

            return ThreadsAccurence;
        }
    }
}
