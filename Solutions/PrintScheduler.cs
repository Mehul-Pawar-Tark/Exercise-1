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

            Console.WriteLine();
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

                String Running_Thread = threads[Thread_Index];
                int len = Running_Thread.Length;


                if (Duration <= len)
                {
                    for (int time = 0; time < Duration; time++)
                    {
                        int index = indexes[Thread_Index];
                        ThreadsAccurence += Running_Thread[index];

                        indexes[Thread_Index]++;
                        indexes[Thread_Index] %= len;
                    }
                }
                else
                {
                    int index = indexes[Thread_Index];
                    ThreadsAccurence += Running_Thread.Substring(index);

                    index = (index + Duration) % len;
                    indexes[Thread_Index] = index;

                    Duration -= Running_Thread.Substring(index).Length;
                    Duration -= Running_Thread.Substring(0, index).Length;

                    for (int i = 0; i < (Duration / len); i++)
                    {
                        ThreadsAccurence += Running_Thread;
                    }

                    ThreadsAccurence += Running_Thread.Substring(0, index);
                }
            }

            return ThreadsAccurence;
        }

    }
}
