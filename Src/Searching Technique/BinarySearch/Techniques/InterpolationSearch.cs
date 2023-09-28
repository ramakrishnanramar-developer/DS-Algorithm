using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SearchTechnique.Techniques
{
    public static class InterpolationSearch
    {
        public static int FindNumber(int[] array, int start, int end, int findNumber)
        {
            int position;
            if (start <= end && findNumber >= array[start] && findNumber <= array[end])
            {
                position = start + (((end - start) / (array[end] - array[start])) * (findNumber - array[start]));
                if (array[position]==findNumber)
                {
                    return ++position;
                }
                else if (array[position]<findNumber)
                {
                    return FindNumber(array,position+1,end,findNumber);
                }
                else if(array[position]>findNumber)
                {
                    return FindNumber(array, start, position - 1, findNumber);
                }
            }
            return -1;
        }
    }
}
