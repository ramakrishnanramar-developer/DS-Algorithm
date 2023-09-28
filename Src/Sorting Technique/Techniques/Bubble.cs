using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Technique
{
    public static class Bubble
    {
        public static int[] Sort(int[] array, int order)
        {
            int temp = 0;
            bool doBreak;
            for (int i = 0; i < array.Length; i++)
            {
                doBreak = true;
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (order == 1)
                    {
                        if (array[j] > array[j + 1])
                        {
                            temp = array[j + 1];
                            array[j + 1] = array[j];
                            array[j] = temp;
                            doBreak = false;
                        }
                    }
                    else
                    {
                        if (array[j] < array[j + 1])
                        {
                            temp = array[j + 1];
                            array[j + 1] = array[j];
                            array[j] = temp;
                            doBreak = false;
                        }
                    }
                }
                if (doBreak)
                {
                    break;
                }
            }
            return array;
        }
    }
}
