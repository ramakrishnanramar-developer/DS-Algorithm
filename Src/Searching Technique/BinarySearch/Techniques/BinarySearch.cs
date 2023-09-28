using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchTechnique
{
    public static class BinarySearch
    {
        public static int FindNumber(int[] array, int findNumber)
        {
            int min = 0, max = array.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (findNumber == array[mid])
                {
                    return ++mid;
                }
                else if (findNumber < array[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
    }
}
